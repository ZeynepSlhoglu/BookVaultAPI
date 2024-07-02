using BookVaultAPI.Data.Repositories;
using BookVaultAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookVaultAPI.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IBookRepository Books { get; }
        INoteRepository Notes { get; }
        IShareRepository Shares { get; }
        Task<int> CompleteAsync();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookVaultContext _context;

        public UnitOfWork(BookVaultContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            Books = new BookRepository(_context);
            Notes = new NoteRepository(_context);
            Shares = new ShareRepository(_context);
        }

        public IUserRepository Users { get; private set; }
        public IBookRepository Books { get; private set; }
        public INoteRepository Notes { get; private set; }
        public IShareRepository Shares { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
