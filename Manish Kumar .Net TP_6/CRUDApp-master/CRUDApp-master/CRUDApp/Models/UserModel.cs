using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDApp.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string ename { get; set; }
        public string email { get; set; }
        public Nullable<int> password { get; set; }
    }
}
