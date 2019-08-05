using FoodStorage_Backend.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Services.AuthService
{
    public interface IAuthService
    {
        Task<DTOAuth> GetTokens(string userName, string password);
    }
}
