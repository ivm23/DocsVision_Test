using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registration.DataInterface;
using Registration.Model;
using System.Data.SqlClient;

namespace Registration.DataInterface.Sql
{
    public class WorkerInterface : IWorker
    {
        private readonly string _connectionString;

        public WorkerInterface(string connectionString)
        {
            _connectionString = connectionString;
        }

        public User Create(string nameW, string loginW)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                User userExist;
                if ((userExist = Get(loginW)) != null) return userExist;

                var user = new User
                {
                    id = Guid.NewGuid(),
                    name = nameW,
                    login = loginW
                };
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "insert into Worker (id, name, login) values (@id, @name, @login)";
                    command.Parameters.AddWithValue("@id", user.id);
                    command.Parameters.AddWithValue("@name", user.name);
                    command.Parameters.AddWithValue("@login", user.login);

                    command.ExecuteNonQuery();

                    return user;
                }
            }
        }

        public User Get(string loginW)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "select id, name from Worker where login = @login";
                    
                    command.Parameters.AddWithValue("@login", loginW);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                id = reader.GetGuid(reader.GetOrdinal("id")),
                                name = reader.GetString(reader.GetOrdinal("name")),
                                login = loginW
                            };
                        }
                        return null;
                    }
                }
            }
        }

        public List<User> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "select id, name, login from Worker";
                    using (var reader = command.ExecuteReader())
                    {
                        List<User> users = new List<User>();
                        while (reader.Read())
                        {
                            Guid idWorker = reader.GetGuid(reader.GetOrdinal("id"));
                            users.Add(new User
                            {
                                id = reader.GetGuid(reader.GetOrdinal("id")),
                                name = reader.GetString(reader.GetOrdinal("name")),
                                login = reader.GetString(reader.GetOrdinal("login"))
                            }
                            );
                        }
                        return users;
                    }
                }
            }
        }
    }
}

