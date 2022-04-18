using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCustomers.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public string? username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Salt { get; set; }
        public string? Role { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string? phone { get; set; }
        
        public ICollection<Address>? adress { get; set; }
        
    }
}
