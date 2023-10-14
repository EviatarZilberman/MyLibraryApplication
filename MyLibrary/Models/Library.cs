using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.Models
{
    public class Library : Father
    {
        public string Owner { get; set; } = string.Empty; // The user id.
        private static List<Book> books = new List<Book>();
        private static Library? instance = null;

        private Library() { }
        private static void Init() 
        {
            // TODO =  Init the user's book list
        }

        private static void ReInit()
        {
            books = new List<Book>();
        }

        public Library Instance()
        {
            if (instance == null)
            {
                instance = new Library();
                Init();
            }
            return instance;
        }

        public override string? InsertQuery()
        {
            throw new NotImplementedException();
        }

        public override string? UpdateQuery(Base b)
        {
            throw new NotImplementedException();
        }

        public override string? DeleteQuery(string id)
        {
            throw new NotImplementedException();
        }

        public override string? CreateQuery()
        {
            throw new NotImplementedException();
        }

        public override string? SelectQuery(string key)
        {
            throw new NotImplementedException();
        }
    }
}
