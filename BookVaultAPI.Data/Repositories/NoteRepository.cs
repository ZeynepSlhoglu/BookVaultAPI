using BookVaultAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookVaultAPI.Data.Repositories
{
    public interface INoteRepository : IRepository<Note>
    {
        IEnumerable<Note> GetNotesByBookId(int bookId);
    }
    public class NoteRepository : Repository<Note>, INoteRepository
    {
        public NoteRepository(BookVaultContext context) : base(context)
        {
        }

        public IEnumerable<Note> GetNotesByBookId(int bookId)
        {
            return _context.Notes.Where(n => n.BookId == bookId).ToList();
        }
    }
}
