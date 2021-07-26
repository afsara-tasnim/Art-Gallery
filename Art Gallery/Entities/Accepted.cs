using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Entities
{
    public class Accepted
    {
        public int id { set; get; }
        public int artId { set; get; }
        public int buyerId { set; get; }
        public int seller { set; get; }
    }
}
