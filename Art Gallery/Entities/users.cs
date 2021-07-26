using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art_Gallery.Entities
{
    public class Users
    {
        public int id { set; get; }
        public string full_name { set; get; }
        public string password { set; get; }
        public int type { set; get; }
        public string phone_number { set; get; }
        public string email { set; get; }
        public string address { set; get; }
        public string status { set; get; }

    }
}
