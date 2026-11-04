using AuthorBooksAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorBooksAPI.Domain.Entities
{
    public class Book : BaseEntity
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string BookNumber { get; set; }
        public int PublishedYear { get; set; }

        public List<Author> Authors { get; set; } = new();
    }
}
