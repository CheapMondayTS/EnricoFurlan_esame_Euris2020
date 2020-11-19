using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSpaceCinema.ISqlProvider;
using TheSpaceCinema.Model;

namespace TheSpaceCinema.SqlProvider
{
    public class CinemaSqlProvider : ConnectionSqlProvider, IGetAllSqlProvider<Cinema>
    {
        public CinemaSqlProvider(string connectionstring) : base(connectionstring)
        {
        }

        public IEnumerable<Cinema> GetAll()
        {
            var cinemaList = new List<Cinema>();
            var sqlQuery = @"SELECT
                                  IdCinema,
                                  NomeCinema

                             FROM [dbo].[Cinema]";

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand(sqlQuery, sqlConnection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cinemaList.Add(new Cinema(Convert.ToInt32(reader["IdCinema"]),
                                                  Convert.ToString(reader["NomeCinema"])));
                    }
                    return cinemaList;
                }
            }
        }
    }
}
