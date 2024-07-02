using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookVaultAPI.DTOs
{
    public class NoteDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsPrivate { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}
