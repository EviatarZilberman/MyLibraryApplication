using System;

namespace MyLibraryApp.Models
{
    public abstract class Base
    {
        public DateTime? CreationDate { get; set; } = DateTime.Now;
        public string? Id { get; set; } = IdToString(Guid.NewGuid().ToString());
        public DateTime? LastChange { get; set; } = null;
        protected static string? IdToString(string? id)
        // Converts the Id to string for the PostgreSQL.
        {
            if (id == null) return null;
            string res = string.Empty;
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] != '-')
                {
                    res += id[i];
                }
            }
            return res;
        }
        public abstract string? InsertQuery();
        public abstract string? UpdateQuery(Base b);
        public abstract string? DeleteQuery(string id);
        public abstract string? CreateQuery();
        public abstract string? SelectQuery(string key);

    }
}
