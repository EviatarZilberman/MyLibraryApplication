using MyLibrary.Forms;
using MyLibraryApp.Enums;
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
        public List<Book> Books { get; set; } = new List<Book>();

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

        public override string? UpdateQuery(Base b)
        {
            return $@"UPDATE public.users SET first_name = '{this.FirstName}', last_name = '{this.LastName}', email = '{this.Email}', birth_date = '{this.BirthDate}', password = '{this.Password}' WHERE internal_id = '{this.Id}'";
        }

        public static async Task<CoreReturns> SelectUserFromTable(string? query)
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
                LogWriter.Instance().WriteLog("User.SelectUserFromTable", e.Message);
                return CoreReturns.ERROR;
            }
            return CoreReturns.SUCCESS;
        }

        public static async Task<CoreReturns> SelectBooksFromTable(string? query)
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
                            Book book = null;
                            try
                            { 
                                book = new Book()
                                {
                                    Title = reader["title"].ToString(),
                                    ForeignId = reader["foreign_id"].ToString(),
                                    Type = reader["type"].ToString(),
                                    //CreationDate = Colboinik.ConvertStringToDate(reader.GetString(1)),
                                    LastChange = reader.GetDateTime(2),
                                    Author = reader["author"].ToString(),
                                    Language = reader["language"].ToString(),
                                    Rank = reader["rank"].ToString(),
                                    AddedToMyLibrary = reader.GetDateTime(8),
                                    PublishDate = reader.GetDateTime(7),
                                    LentTo = reader["lent_to"].ToString()
                                };
                            }
                            catch
                            {
                                 book = new Book()
                                {
                                     ForeignId = reader["foreign_id"].ToString(),
                                     Title = reader["title"].ToString(),
                                    Type = reader["type"].ToString(),
                                    //CreationDateString = Book.DEFAULT,
                                    LastChangeString = string.Empty,
                                    Author = reader["author"].ToString(),
                                    Language = reader["language"].ToString(),
                                    Rank = reader["rank"].ToString(),
                                    AddedToMyLibrary = reader.GetDateTime(8),
                                    PublishDate = reader.GetDateTime(7),
                                    LentTo = reader["lent_to"].ToString()
                                };
                            }
                            Login.LoggedUser?.Books.Add(book);
                        }
                        await reader.CloseAsync();
                    }
                }
            }
            catch (Exception e)
            {
                LogWriter.Instance().WriteLog("User.SelectBooksFromTable", e.Message);
                return CoreReturns.ERROR;
            }
            return CoreReturns.SUCCESS;
        }
    }
}

