using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MyLibraryApp.Models
{
    public class Book : Father
    {
        [NotNull]
        [Required]
        public string Title { get; set; } = string.Empty;
        public string? Author { get; set; } = string.Empty;
        public string? Language { get; set; } = string.Empty;
        public string? Type { get; set; } = string.Empty;
        public DateTime? PublishDate { get; set; }
        public DateTime? AddedToMyLibrary { get; set; }
        public string? LentTo { get; set; } = string.Empty;
        [Range(0, 10)]
        public int? Rank { get; set; }
        public bool SpecialPublishDate { get; set; } = false;

        public Book(Book b)
        {
            this.Title = b.Title;
            this.Author = b.Author;
            this.Language = b.Language;
            this.Type = b.Type;
            this.PublishDate = b.PublishDate;
            this.AddedToMyLibrary = b.AddedToMyLibrary;
            this.LentTo = b.LentTo;
            this.Rank = b.Rank;
            this.SpecialPublishDate = b.SpecialPublishDate;
        }
        public Book() { }
        public Book(string title, string? author = null,
            string? language = "Hebrew", string? type = null,
            DateTime? creationDate = null,
            DateTime? added = null, string? lentTo = null,
            int? rank = null, bool specialPublishDate = false)
        {
            this.Title = title;
            this.Author = author;
            this.Language = language;
            this.Type = type;
            this.PublishDate = creationDate;
            this.AddedToMyLibrary = added;
            this.LentTo = lentTo;
            this.Rank = rank;
            this.SpecialPublishDate= specialPublishDate;
        }

        public override string? InsertQuery()
        {
            return $@"Insert into public.books(creation_date, internal_id, title, author, language, type, publish_date, add_to_my_library, lent_to, rank, foreign_id) values('{this.CreationDate}', '{this.Id}', '{this.Title}', '{this.Author}', '{this.Language}', '{this.Type}', '{this.PublishDate}', '{this.AddedToMyLibrary}', '{this.LentTo}', '{this.Rank}', '{this.ForeignId}')";
        }

        public string? InsertQuery(User u)
        {
            if (u == null) return null;
            return $@"Insert into public.users(creation_date, internal_id, title, author, language, type, publish_date, add_to_my_library, lent_to, rank, foreign_id) values('{this.CreationDate}', '{this.Id}', '{this.Title}', '{this.Author}', '{this.Language}', '{this.Type}', '{this.PublishDate}', '{this.AddedToMyLibrary}', '{this.LentTo}', '{this.Rank}', '{u.Id}')";
        }

        public override string? DeleteQuery(string id)
        {
            throw new NotImplementedException();
        }

        public override string? CreateQuery()
        {
            throw new NotImplementedException();
        }

        public override string? UpdateQuery(Base b)
        {
            throw new NotImplementedException();
        }

        public override string? SelectQuery(string key)
        {
            throw new NotImplementedException();
        }
    }
}
