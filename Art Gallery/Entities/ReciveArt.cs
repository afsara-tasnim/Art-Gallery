using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Entities
{
    public class ReciveArt
    {
        public int id { set; get; }
        public int d_id {set; get;}
        public int art_id { set; get; }
        public string art_Status { set; get; }
        public int buyerId { set; get; }

        public string collectdate { set; get; }
        public string address { set; get; }

    }
}
