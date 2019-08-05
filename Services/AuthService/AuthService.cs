using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodStorage_Backend.Models.DTO;

namespace FoodStorage_Backend.Services.AuthService
{
    public class AuthService : IAuthService
    {
        public Task<DTOAuth> GetTokens(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
