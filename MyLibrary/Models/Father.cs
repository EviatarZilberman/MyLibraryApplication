using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApp.Models
{
    public abstract class Father : Base
    {
        public string? ForeignId { get; set; } = string.Empty;

        public override string? DeleteQuery(string id)
        {
            throw new NotImplementedException();
        }

        public override string? InsertQuery()
        {
            throw new NotImplementedException();
        }

        public override string? UpdateQuery(Base b)
        {
            throw new NotImplementedException();
        }
    }
}
