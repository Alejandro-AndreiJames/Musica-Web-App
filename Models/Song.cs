using System.Linq;
using System.Threading.Tasks;
using System;

namespace Musica_Web_App.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string SongQuestion { get; set; }
        public string SongAnswer { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public Song()
        {
                
        }
    }
}

  
