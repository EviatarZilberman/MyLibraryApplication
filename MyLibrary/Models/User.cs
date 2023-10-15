using MyLibrary.Forms;
using Npgsql;
using PostgreSQLDBManager;
using System.Data;
using System.Linq.Expressions;
using Utilities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyLibraryApp.Models
{
    public class User : Base
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } = DateTime.MinValue;
        public string Password { get; set; } = string.Empty;
        public string ManipulatedPassword { get; set; } = string.Empty;
        public string? Username { get; set; } = string.Empty;

        public User() { }
        public User(string firstName, string lastName, string email, string password, string username, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.BirthDate = birthDate;
            this.Username = username;
        }

        public User(DateTime creationDate, DateTime lastChange, string internalId, string firstName, string lastName, string email, string password, string username, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.BirthDate = birthDate;
            this.Username = username;
            this.CreationDate = creationDate;
            this.LastChange = lastChange;
            this.Id = internalId;
        }

        public override string? CreateQuery()
        {
            throw new NotImplementedException();
        }

        public override string? DeleteQuery(string id)
        {
            return $@"Delete from public.users * where id = '{this.Id}'";
        }

        public override string? InsertQuery()
        {
            return $@"Insert into public.users(creation_date, internal_id, first_name, last_name, email, birth_date, password, username) values('{this.CreationDate}', '{this.Id}', '{this.FirstName}', '{this.LastName}', '{this.Email}', '{this.BirthDate}', '{this.Password}', '{this.Username}')";
        }

        public override string? SelectQuery(string key)
        {
            if (string.IsNullOrEmpty(key) || string.IsNullOrWhiteSpace(key)) return null;
            return $"SELECT username FROM public.users;";
        }

      /*  public string? SelectQuery(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password)) return null;
            return $"SELECT * FROM public.users WHERE username = '{username}' AND password = '{password}';";
        }*/

        public override string? UpdateQuery(Base b)
        {
            return $@"UPDATE public.users SET first_name = '{this.FirstName}', last_name = '{this.LastName}', email = '{this.Email}', birth_date = '{this.BirthDate}', password = '{this.Password}' WHERE internal_id = '{this.Id}'";
        }

        public static async Task<CoreReturns> SelectFromTable(string? query)
        {
            await DBManager.ConnectionString.CloseAsync();
            await DBManager.ConnectionString.OpenAsync();

            try
            {
                using (NpgsqlCommand command = new NpgsqlCommand(query, DBManager.ConnectionString))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Login.LoggedUser = new User()
                            {
                                Id = reader.GetString(0),
                                CreationDate = reader.GetDateTime(1),
                                LastChange = reader.GetDateTime(2),
                                FirstName = reader.GetString(3),
                                LastName = reader.GetString(4),
                                Email = reader.GetString(5),
                                Password = reader.GetString(6),
                                BirthDate = reader.GetDateTime(7),
                                Username = reader.GetString(8),
                            };
                        }
                            await reader.CloseAsync();
                    }
                }
            }
            catch (Exception e)
            {
                LogWriter.Instance().WriteLog("User.SelectFromTable", e.Message);
                return CoreReturns.ERROR;
            }
            return CoreReturns.SUCCESS;
        }
    }
}

/*using Npgsql;
using System;

class Program
{
    static void Main()
    {
        string connectionString = "Host=myserver;Port=5432;Database=mydatabase;Username=myuser;Password=mypassword;";
        string usernameInput = usernameBox.Text; // Get the username input from the user
        string passwordInput = passwordBox.Text; // Get the password input from the user

        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            string sql = "SELECT username, password FROM public.users WHERE username = @username AND password = @password";

            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@username", usernameInput);
                command.Parameters.AddWithValue("@password", passwordInput);

                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    // Process the result
                    if (reader.Read())
                    {
                        // Authentication successful, do something
                    }
                    else
                    {
                        // Authentication failed, handle accordingly
                    }
                }
            }
        }
    }
}
*/