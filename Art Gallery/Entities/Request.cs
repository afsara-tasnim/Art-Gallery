using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Entities
{
    public class Request
    {
        public int id { set; get;}
        public int artid { set; get; }
      
        public int buyerId { set; get; }
        public int sellerId { set; get; }
        public string phoneNumber { set; get; }   
    }
}
