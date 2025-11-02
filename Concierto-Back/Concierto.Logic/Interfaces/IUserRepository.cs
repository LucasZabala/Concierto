using Concierto.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto.Logic.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByUserNameAsync(string UserName);
        Task<User> GetUserByIdAsync(int id);
    }
}
