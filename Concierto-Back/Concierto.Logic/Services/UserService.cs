using Concierto.Logic.Interfaces;
using Concierto.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto.Logic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);
            if (user == null)
            {
                throw new ArgumentNullException($"No se encontro usauiro con el id: {id}");
            }
            return user;
        }

        public async Task<User> GetUserByUserNameAsync(string username)
        {
            var user = await _userRepository.GetUserByUserNameAsync(username);
            if (user == null)
            {
                throw new ArgumentNullException($"No existe nombre de usuario: {username}");
            }

            return user;

        }
    }
}
