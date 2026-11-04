using AuthorBooksAPI.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorBooksAPI.Application.DTO
{
    public class BookDto : BaseDto
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string BookNumber { get; set; }
        public int PublishedYear { get; set; }
    }
}
