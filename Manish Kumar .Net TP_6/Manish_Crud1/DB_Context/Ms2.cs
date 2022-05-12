using System;
using System.Collections.Generic;

#nullable disable

namespace Manish_Crud1.DB_Context
{
    public partial class Ms2
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long? Mobile { get; set; }
        public string Email { get; set; }
        public int? Zipcode { get; set; }
    }
}
