using MyLibrary.Forms;
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
        public string? Author { get; set; } = DEFAULT;
        public string? Language { get; set; } = DEFAULT;
        public string? Type { get; set; } = DEFAULT;
        public DateTime? PublishDate { get; set; } = DateTime.MinValue;
        public string? PublishDateString { get; set; } = DEFAULT;
        public DateTime? AddedToMyLibrary { get; set; } = DateTime.MinValue;
        public string? AddedToMyLibraryString { get; set; } = DEFAULT;
        public string? LentTo { get; set; } = "Not Lent";
        public string? Rank { get; set; } = DEFAULT;
        public static readonly string DEFAULT = "Unknown";

        public Book() { }
        public Book(string title, string? author = null,
            string? language = "Hebrew", string? type = null,
            DateTime? creationDate = null,
            DateTime? added = null, string? lentTo = null,
            string? rank = null)
        {
            this.Title = title;
            if (!string.IsNullOrEmpty(author) || !string.IsNullOrWhiteSpace(author))
            {
                this.Author = author;
            }
            else
            {
                this.Author = DEFAULT;
            }
            if (!string.IsNullOrEmpty(language) || !string.IsNullOrWhiteSpace(language))
            {
            this.Language = language;
            }
            else
            {
                this.Language = DEFAULT;
            }
            if (!string.IsNullOrEmpty(type) || !string.IsNullOrWhiteSpace(type))
            {
                this.Type = type;
            }
            else
            {
                this.Type = DEFAULT;
            }
            if (!string.IsNullOrEmpty(rank) || !string.IsNullOrWhiteSpace(rank))
            {
                this.Rank = Rank;
            }
            else
            {
                this.Rank = DEFAULT;
            }
            if (!string.IsNullOrEmpty(lentTo) || !string.IsNullOrWhiteSpace(lentTo))
            {
                this.LentTo = lentTo;
            }
            else
            {
                this.LentTo = DEFAULT;
            }
   /*         if (!string.IsNullOrEmpty(language) || !string.IsNullOrWhiteSpace(language))
            {
                this.Language = language;
            }
            else
            {
                this.Language = DEFAULT;
            }
            if (!string.IsNullOrEmpty(language) || !string.IsNullOrWhiteSpace(language))
            {
                this.Language = language;
            }
            else
            {
                this.Language = DEFAULT;
            }*/
            this.PublishDate = creationDate;
            this.AddedToMyLibrary = added;
        }

        public override string? InsertQuery()
        {
            return $@"Insert into public.books(creation_date, internal_id, title, author, language, type, publish_date, add_to_my_library, lent_to, rank, foreign_id, publish_date_string, add_to_my_library_string)
            values( '{this.CreationDate}', '{this.Id}', '{this.Title}', '{this.Author}', '{this.Language}', '{this.Type}', '{this.PublishDate}', '{this.AddedToMyLibrary}', '{this.LentTo}', '{this.Rank}', '{this.ForeignId}', '{this.PublishDateString}', '{this.AddedToMyLibraryString}')";
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

        public static implicit operator List<object>(Book v)
        {
            throw new NotImplementedException();
        }
    }
}
