using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSpaceCinema.ISqlProvider;
using TheSpaceCinema.Model;

namespace TheSpaceCinema.SqlProvider
{
    public class SpettatoreSqlProvider : ConnectionSqlProvider, IGetAllSqlProvider<Spettatore>, IInsertSqlProvider<Spettatore>
    {
        public SpettatoreSqlProvider(string connectionstring) : base(connectionstring)
        {
        }

        public IEnumerable<Spettatore> GetAll()
        {
            var spettatoreList = new List<Spettatore>();
            var sqlQuery = @"SELECT
                                  IdSpettatore,
                                  NomeSpettatore,
                                  CognomeSpettatore,
                                  DataNascita

                             FROM [dbo].[Spettatore]";

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand(sqlQuery, sqlConnection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        spettatoreList.Add(new Spettatore(Convert.ToInt32(reader["IdSpettatore"]),
                                                          Convert.ToString(reader["NomeSpettatore"]),
                                                          Convert.ToString(reader["CognomeSpettatore"]),
                                                          Convert.ToDateTime(reader["DataNascita"])));
                    }
                    return spettatoreList;
                }
            }
        }

        public void Insert(Spettatore spettatore)
        {
            var sqlQuery = @"INSERT INTO [dbo].[Spettatore]

                                        ([IdSpettatore],
                                         [NomeSpettatore],
                                         [CognomeSpettatore],
                                         [DataNascita])
                                
                             VALUES     (@IdSpettatore,
                                         @NomeSpettatore,
                                         @CognomeSpettatore,
                                         @DataNascita)";

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand(sqlQuery, sqlConnection))
                {
                    command.Parameters.AddWithValue("@IdSpettatore", spettatore.IdSpettatore);
                    command.Parameters.AddWithValue("@NomeSpettatore", spettatore.NomeSpettatore);
                    command.Parameters.AddWithValue("@CognomeSpettatore", spettatore.CognomeSpettatore);
                    command.Parameters.AddWithValue("@DataNascita", spettatore.DataNascita);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
