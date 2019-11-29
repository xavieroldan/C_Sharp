using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MVCAppAspNetTest.Models;
using MySql.Data.MySqlClient;

namespace MVCAppAspNetTest.Clases
{
    public class UserContext
    {
        public string ConnectionString { get; set; }

        public UserContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        //Get one user
        public async Task<LoginModel> FindOneAsync(string nameUser)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var commandText = @"SELECT name,password,errorlogin,islocked FROM users Where name=@name;";
                MySqlCommand cmd = new MySqlCommand(commandText, conn);
                cmd.Parameters.Add(new MySqlParameter
                {
                    ParameterName = "@name",
                    DbType = DbType.String,
                    Value = nameUser,
                });

                using (var reader = cmd.ExecuteReader())
                {
                    if (await reader.ReadAsync())
                    {
                        return new LoginModel()
                        {                           
                            userid = await reader.GetFieldValueAsync<int>(0),
                            name = nameUser,
                            password = await reader.GetFieldValueAsync<string>(2),
                            errorLogin = await reader.GetFieldValueAsync<int>(3),
                            isLocked = await reader.GetFieldValueAsync<bool>(4),
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }            

        //Get all users
        public async Task<List<LoginModel>> GetAllUsersAsync()
        {
            List<LoginModel> userList = new List<LoginModel>();
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from users;", conn);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userList.Add(new LoginModel()
                            {
                                userid = await reader.GetFieldValueAsync<int>(0),
                                name = await reader.GetFieldValueAsync<string>(1),
                                password = await reader.GetFieldValueAsync<string>(2),
                                errorLogin = await reader.GetFieldValueAsync<int>(3),
                                isLocked = await reader.GetFieldValueAsync<bool>(4),
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }           

            return userList;
        }
        // Update user
        public async Task UpdateAsync(LoginModel user)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var commandText = @"UPDATE users SET name=@name, password=@password, errorlogin=@errorlogin, islocked=@islocked Where name=@name;";

                MySqlCommand cmd = new MySqlCommand(commandText, conn);

                cmd.Parameters.Add(new MySqlParameter
                {
                    ParameterName = "@name",
                    DbType = DbType.String,
                    Value = user.name,
                });

                cmd.Parameters.Add(new MySqlParameter
                {
                    ParameterName = "@password",
                    DbType = DbType.String,
                    Value = user.password,
                });

                cmd.Parameters.Add(new MySqlParameter
                {
                    ParameterName = "@errorlogin",
                    DbType = DbType.Int16,
                    Value = user.errorLogin,
                });

                cmd.Parameters.Add(new MySqlParameter
                {
                    ParameterName = "@islocked",
                    DbType = DbType.Boolean,
                    Value = user.isLocked,
                });                

                await cmd.ExecuteNonQueryAsync();
            }

        }
        //Create user
        public async Task InsertAsync(LoginModel user)
        {
            //user.userid = Guid.NewGuid().ToString();
            //Auto generate id by the db

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                var commandText = @"INSERT INTO users (name,password,errorlogin,islocked) VALUES (@name,@password,@errorlogin,@islocked);";

                MySqlCommand cmd = new MySqlCommand(commandText, conn);

                cmd.Parameters.Add(new MySqlParameter
                {
                    ParameterName = "@name",
                    DbType = DbType.String,
                    Value = user.name,
                });

                cmd.Parameters.Add(new MySqlParameter
                {
                    ParameterName = "@password",
                    DbType = DbType.String,
                    Value = user.password,
                });

                cmd.Parameters.Add(new MySqlParameter
                {
                    ParameterName = "@errorlogin",
                    DbType = DbType.Int32,
                    Value = user.errorLogin,
                });

                cmd.Parameters.Add(new MySqlParameter
                {
                    ParameterName = "@islocked",
                    DbType = DbType.Boolean,
                    Value = user.isLocked,
                });           

                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}
