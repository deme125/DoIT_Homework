using Domain.Interfaces;
using Domain.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Repository.Repositories
{
    public class InstructorRepository : IInstructorRepository
    {
        private readonly string _connectionString;

        public InstructorRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool CreateInstructor(Instructor instructor)
        {
            const string query = "INSERT INTO INSTRUCTORS (FirstName, LastName, Email) VALUES (@FirstName, @LastName, @Email)";

            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 20).Value = (object?)instructor.FirstName ?? DBNull.Value;
            command.Parameters.Add("@LastName", SqlDbType.NVarChar, 30).Value = (object?)instructor.LastName ?? DBNull.Value;
            command.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = (object?)instructor.Email ?? DBNull.Value;

            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public bool DeleteInstructor(int id)
        {
            // Updated SQL clause to target IstructorID
            const string query = "DELETE FROM INSTRUCTORS WHERE IstructorID = @IstructorID";

            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@IstructorID", SqlDbType.Int).Value = id;

            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }

        public IEnumerable<Instructor> GetAllInstructors()
        {
            var instructors = new List<Instructor>();
            const string query = "SELECT IstructorID, FirstName, LastName, Email FROM INSTRUCTORS";

            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(query, connection);

            connection.Open();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                instructors.Add(new Instructor
                {
                    Id = reader.GetInt32(reader.GetOrdinal("IstructorID")),
                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                    Email = reader.GetString(reader.GetOrdinal("Email"))
                });
            }

            return instructors;
        }

        public Instructor? GetByID(int id)
        {
            // Updated SQL query to target IstructorID
            const string query = "SELECT IstructorID, FirstName, LastName, Email FROM INSTRUCTORS WHERE IstructorID = @IstructorID";

            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@IstructorID", SqlDbType.Int).Value = id;

            connection.Open();
            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Instructor
                {
                    Id = reader.GetInt32(reader.GetOrdinal("IstructorID")),
                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                    Email = reader.GetString(reader.GetOrdinal("Email"))
                };
            }

            return null;
        }

        public bool UpdateInstructor(Instructor instructor)
        {
            // Updated SQL query to target IstructorID in WHERE clause
            const string query = "UPDATE INSTRUCTORS SET FirstName = @FirstName, LastName = @LastName, Email = @Email WHERE IstructorID = @IstructorID";

            using var connection = new SqlConnection(_connectionString);
            using var command = new SqlCommand(query, connection);

            command.Parameters.Add("@IstructorID", SqlDbType.Int).Value = instructor.Id;
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 20).Value = (object?)instructor.FirstName ?? DBNull.Value;
            command.Parameters.Add("@LastName", SqlDbType.NVarChar, 30).Value = (object?)instructor.LastName ?? DBNull.Value;
            command.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = (object?)instructor.Email ?? DBNull.Value;

            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }
    }
}