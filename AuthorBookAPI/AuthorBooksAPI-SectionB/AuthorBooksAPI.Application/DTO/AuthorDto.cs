using AuthorBooksAPI.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorBooksAPI.Application.DTO
{
    public class AuthorDto : BaseDto
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

    }
}
