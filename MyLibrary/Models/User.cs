using Utilities;

namespace MyLibraryApp.Models
{
    public class User : Base
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateOnly BirthDate { get; set; } = DateOnly.MinValue;
        public string Password { get; set; } = string.Empty;
        public string ManipulatedPassword { get; set; } = string.Empty;
        
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
            return $@"Insert into public.users(creation_date, internal_id, first_name, last_name, email, birth_date, password) values('{this.CreationDate}', '{this.Id}', '{this.FirstName}', '{this.LastName}', '{this.Email}', '{this.BirthDate}', '{this.Password}')";
        }

        public override string? UpdateQuery(Base b) 
        {
            return $@"UPDATE public.users SET first_name = '{this.FirstName}', last_name = '{this.LastName}', email = '{this.Email}', birth_date = '{this.BirthDate}', password = '{this.Password}' WHERE internal_id = '{this.Id}';";
        }
    }
}
