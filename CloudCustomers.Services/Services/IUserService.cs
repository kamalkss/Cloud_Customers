using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudCustomers.Data.Models;

namespace CloudCustomers.Services.Services
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> GetAllUsers();
        public Task<User>? GetUserById(int id);
    }
}
