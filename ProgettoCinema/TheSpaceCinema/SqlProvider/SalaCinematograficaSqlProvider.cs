using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSpaceCinema.ISqlProvider;
using TheSpaceCinema.Model;

namespace TheSpaceCinema.SqlProvider
{
    public class SalaCinematograficaSqlProvider : ConnectionSqlProvider, IGetAllSqlProvider<SalaCinematografica>
    {
        public SalaCinematograficaSqlProvider(string connectionstring) : base(connectionstring)
        {
        }

        public IEnumerable<SalaCinematografica> GetAll()
        {
            var salaCinematograficaList = new List<SalaCinematografica>();
            var sqlQuery = @"SELECT
                                  IdSalaCinematografica,
                                  NomeSalaCinematografica,
                                  Capienza

                             FROM [dbo].[SalaCinematografica]";

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand(sqlQuery, sqlConnection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        salaCinematograficaList.Add(new SalaCinematografica(Convert.ToInt32(reader["IdSalaCinematografica"]),
                                                                            Convert.ToString(reader["NomeSalaCinematografica"]),
                                                                            Convert.ToInt32(reader["Capienza"])));
                    }
                    return salaCinematograficaList;
                }
            }
        }
    }
}
