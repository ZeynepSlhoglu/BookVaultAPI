using BookVaultAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookVaultAPI.Data.Repositories
{
    public interface IShareRepository : IRepository<Share>
    {
        IEnumerable<Share> GetSharesByUserId(int userId);
    }
    public class ShareRepository : Repository<Share>, IShareRepository
    {
        public ShareRepository(BookVaultContext context) : base(context)
        {
        }

        public IEnumerable<Share> GetSharesByUserId(int userId)
        {
            return _context.Shares.Where(s => s.SharedWithUserId == userId).ToList();
        }
    }
}
