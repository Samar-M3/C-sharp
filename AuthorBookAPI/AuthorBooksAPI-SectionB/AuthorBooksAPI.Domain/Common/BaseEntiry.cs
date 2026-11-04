using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorBooksAPI.Domain.Common
{
    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
