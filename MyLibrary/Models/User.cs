using Utilities;

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
        public User(string firstName, string lastName, string email, string password, string username, DateTime birthDate) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.BirthDate = birthDate;
            this.Username = username;
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
            return $@"UPDATE public.users SET first_name = '{this.FirstName}', last_name = '{this.LastName}', email = '{this.Email}', birth_date = '{this.BirthDate}', password = '{this.Password}' WHERE internal_id = '{this.Id}';";
        }
    }
}
