﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

namespace DavidNaputi.MovieLib.Data.Sql
{
    public class SqlMovieDatabase : MovieDatabase

    {
        protected SqlMovieDatabase( string connectionString )
        {
            if (connectionString == null)
                throw new ArgumentNullException(nameof(connectionString));
            if (connectionString == "")
                throw new ArgumentException("Connection string cannot be empty.",
                                            nameof(connectionString));

            _connectionString = connectionString;
        }

        protected override Movie AddCore( Movie movie )
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("Addmovie", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@name", movie.Title);
                cmd.Parameters.AddWithValue("@price", movie.Length);
                cmd.Parameters.AddWithValue("@description", movie.Description);

                var parm = cmd.CreateParameter();
                parm.ParameterName = "@isDiscontinued";
                parm.DbType = System.Data.DbType.Boolean;
                parm.Value = movie.IsOwned;
                cmd.Parameters.Add(parm);

                conn.Open();
                var result = cmd.ExecuteScalar();

                var id = Convert.ToInt32(result);
                movie.Id = id;
            };

            return movie;
        }

        protected override IEnumerable<Movie> GetAllCore()
        {
            var items = new List<Movie>();

            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("GetAllmovies", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                conn.Open();

                var ds = new DataSet();

                var da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                da.Fill(ds);

                if (ds.Tables.Count == 1)
                {
                    foreach (var row in ds.Tables[0].Rows.OfType<DataRow>())
                    {
                        var movie = new Movie() {
                            Id = Convert.ToInt32(row["Id"]),
                            Title = row.Field<string>("Title"),
                            Description = row.Field<string>("Description"),
                            Length = row.Field<decimal>("Length"),
                            IsOwned = row.Field<bool>("IsOwned")
                        };

                        items.Add(movie);
                    };
                };
            };

            return items;
        }

        private static Movie ReadData( SqlDataReader reader )
                        => new Movie() {
                            Id = Convert.ToInt32(reader["Id"]),
                            Title = reader.GetFieldValue<string>(1),
                            Length = reader.GetDecimal(2),
                            Description = reader.GetString(3),
                            IsOwned = reader.GetBoolean(4)
                        };

        protected override Movie GetCore( int id )
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("Getmovie", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id", id));

                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                        return ReadData(reader);
                };
            };

            return null;
        }

        protected override Movie GetMovieByTitleCore( string name )
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("GetAllmovies", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var movie = ReadData(reader);
                        if (String.Compare(movie.Title, name, true) == 0)
                            return movie;
                    };
                };
            };

            return null;
        }

        protected override void RemoveCore( int id )
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("Removemovie", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id", id));

                conn.Open();
                cmd.ExecuteNonQuery();
            };
        }

        protected override Movie UpdateCore( Movie movie )
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("Updatemovie", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@id", movie.Id));
                cmd.Parameters.AddWithValue("@name", movie.Title);
                cmd.Parameters.AddWithValue("@price", movie.Length);
                cmd.Parameters.AddWithValue("@description", movie.Description);

                var parm = cmd.CreateParameter();
                parm.ParameterName = "@isDiscontinued";
                parm.DbType = System.Data.DbType.Boolean;
                parm.Value = movie.IsOwned;
                cmd.Parameters.Add(parm);

                conn.Open();
                cmd.ExecuteNonQuery();
            };

            return movie;
        }

        private readonly string _connectionString;

    }
}
