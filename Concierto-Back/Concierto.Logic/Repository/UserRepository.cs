using Concierto.Logic.Data;
using Concierto.Logic.Interfaces;
using Concierto.Logic.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto.Logic.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ConciertoDbContext _context;

        public UserRepository(ConciertoDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> GetUserByUserNameAsync(string UserName)
        {
            return await _context.Users.FirstOrDefaultAsync(u=>u.UserName == UserName);            
        }
    }
}
