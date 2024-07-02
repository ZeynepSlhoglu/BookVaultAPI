using BookVaultAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookVaultAPI.Data.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetBooksByUserId(int userId);
    }
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(BookVaultContext context) : base(context)
        {
        }

        public IEnumerable<Book> GetBooksByUserId(int userId)
        {
            return _context.Books.Where(b => b.Id == userId).ToList();
        }
    }
}
