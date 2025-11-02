using Concierto.Logic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concierto.Logic.Interfaces
{
    public interface IAuthService
    {
        Task<string> Register(RegisterDTO registerDTO);
        Task<string> Login(LoginDTO loginDTO);

    }
}
