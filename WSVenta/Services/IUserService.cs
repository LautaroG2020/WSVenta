using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSVenta.Models;
using WSVenta.Models.Response;

namespace WSVenta.Services
{
    public interface IUserService 
    {
        UserResponse Auth(AuthRequest model);
    }
}
