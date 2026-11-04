using AuthorBooksAPI.Domain.Entities;
using AuthorBooksAPI.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AuthorBooksAPI.Infrastructure.Implementations
{
    public class BooksRepository : IBooksRepository
    {
        private readonly AuthorBooksAPIDbContext _authorBooksAPIDbContext;

        public BooksRepository(AuthorBooksAPIDbContext authorBooksAPIDbContext)
        {
            _authorBooksAPIDbContext = authorBooksAPIDbContext;
        }

        public Task<List<Book>> GetAllAsync()
        {
            return _authorBooksAPIDbContext.Books.Where(x => x.DeletedDate == null).ToListAsync();
        }
    }
}
