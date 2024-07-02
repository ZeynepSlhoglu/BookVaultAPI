using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookVaultAPI.Entities
{
    public class Note
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsPrivate { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
    }
}
