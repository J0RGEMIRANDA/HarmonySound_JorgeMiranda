using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonySound.Models
{
    public class ContentAlbum
    {
        [Key] public int Id { get; set; }
        public int ContentId { get; set; }
        public int AlbumId { get; set; }
        public Content? Content { get; set; }
        public Album? Album { get; set; }
    }
}
