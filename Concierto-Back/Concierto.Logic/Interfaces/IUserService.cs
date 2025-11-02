using Concierto.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto.Logic.Interfaces
{
    public interface IUserService
    {
        Task<User> GetUserByUserNameAsync(string username);
        Task<User> GetUserByIdAsync(int id);
    }
}
