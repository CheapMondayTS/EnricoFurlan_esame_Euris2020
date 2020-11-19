using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSpaceCinema.ISqlProvider;
using TheSpaceCinema.Model;

namespace TheSpaceCinema.SqlProvider
{
    public class FilmSqlProvider : ConnectionSqlProvider, IGetAllSqlProvider<Film>, IInsertSqlProvider<Film>
    {
        public FilmSqlProvider(string connectionstring) : base(connectionstring)
        {
        }

        public IEnumerable<Film> GetAll()
        {
            var filmList = new List<Film>();
            var sqlQuery = @"SELECT
                                  IdFilm,
                                  TitoloFilm,
                                  Autore,
                                  Produttore,
                                  Genere,
                                  Durata

                             FROM [dbo].[Film]";

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand(sqlQuery, sqlConnection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        filmList.Add(new Film(Convert.ToInt32(reader["IdFilm"]),
                                              Convert.ToString(reader["TitoloFilm"]),
                                              Convert.ToString(reader["Autore"]),
                                              Convert.ToString(reader["Produttore"]),
                                              Convert.ToString(reader["Genere"]),
                                              Convert.ToInt32(reader["Durata"])));
                    }
                    return filmList;
                }
            }
        }

        public void Insert(Film film)
        {
            var sqlQuery = @"INSERT INTO [dbo].[Film]

                                        ([IdFilm],
                                         [TitoloFilm],
                                         [Autore],
                                         [Produttore],
                                         [Genere],
                                         [Durata])
                                
                             VALUES     (@IdFilm,
                                         @TitoloFilm,
                                         @Autore,
                                         @Produttore,
                                         @Genere,
                                         @Durata)";

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();

                using (var command = new SqlCommand(sqlQuery, sqlConnection))
                {
                    command.Parameters.AddWithValue("@IdFilm", film.IdFilm);
                    command.Parameters.AddWithValue("@TitoloFilm", film.TitoloFilm);
                    command.Parameters.AddWithValue("@Autore", film.Autore);
                    command.Parameters.AddWithValue("@Produttore", film.Produttore);
                    command.Parameters.AddWithValue("@Genere", film.Genere);
                    command.Parameters.AddWithValue("@Durata", film.Durata);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
