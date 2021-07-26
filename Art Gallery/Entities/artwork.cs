using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Entities
{
    public class Artwork
    {
        public int id { set; get; }
        public string name { set; get; }
        public string uploadDate { set; get; }
        public string type { set; get; }
        public byte[] image { set; get; }
        public int price { set; get; }
        public string sold { set; get; }
        public int creator_id { set; get; }
        
    }
}
