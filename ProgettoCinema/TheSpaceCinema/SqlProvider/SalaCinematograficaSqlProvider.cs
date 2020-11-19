using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSpaceCinema.ISqlProvider;
using TheSpaceCinema.Model;

namespace TheSpaceCinema.SqlProvider
{
    public class SalaCinematograficaSqlProvider : ConnectionSqlProvider, IGetAllSqlProvider<SalaCinematografica>, IGetByFilterSqlProvider<SalaCinematografica>
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

        public IEnumerable<SalaCinematografica> GetByFilter(int idSalaCinematografica)
        {
            {
                var salaCinematograficaList = new List<SalaCinematografica>();
                var sqlQuery = @"SELECT
                                 SCF.[IdSalaCinematografica],
                                 F.TitoloFilm

                                 FROM  [TheSpaceCinema].[dbo].[SalaCinematograficaFilm-incr] SCF

                                 JOIN  [dbo].[Film] F
                                 ON    SCF.IdSalaCinematografica = F.IdFilm

                                 WHERE SCF.IdSalaCinematografica = @IdSalaCinematografica";

                using (var sqlConnection = new SqlConnection(_connectionString))
                {
                    sqlConnection.Open();

                    using (var command = new SqlCommand(sqlQuery, sqlConnection))
                    {
                        command.Parameters.AddWithValue("@IdSalaCinematografica", idSalaCinematografica);

                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            salaCinematograficaList.Add(new SalaCinematografica()
                            {
                                IdSalaCinematografica = Convert.ToInt32(reader["IdSalaCinematografica"]),
                                NomeSalaCinematografica = Convert.ToString(reader["NomeSalaCinematografica"])
                            });

                        }
                        return salaCinematograficaList;
                    }
                };
            }
        }
    }
}
