using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookVaultAPI.Entities
{
    public class Share
    {
        public int Id { get; set; }
        public int NoteId { get; set; }
        public Note Note { get; set; }
        public int SharedWithUserId { get; set; }
        public User SharedWithUser { get; set; }
        public string PrivacySetting { get; set; }
    }
}
