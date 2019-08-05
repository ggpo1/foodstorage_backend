using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Models.DTO
{
    public class DTOAuth
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
