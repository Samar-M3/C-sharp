using AuthorBooksAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthorBooksAPI.Infrastructure.Interfaces
{
    public interface IBooksRepository
    {
        Task<List<Book>> GetAllAsync();
    }
}
