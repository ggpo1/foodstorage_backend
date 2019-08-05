using FoodStorage_Backend.Models;
using FoodStorage_Backend.Models.DataBase;
using FoodStorage_Backend.Services.RoomService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodStorage_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController
    {
        IRoomService service;

        public RoomController(IRoomService service)
        {
            this.service = service;
        }

        #region Get data methods
        [HttpGet]
        public async Task<List<Room>> GetRooms()
        {
            return await service.GetRooms();
        }

        [HttpGet]
        [Route("getroombyid")]
        public async Task<Room> GetRoomByID(int roomID)
        {
            return await service.GetRoomByID(roomID);
        }

        [HttpGet]
        [Route("getapartmentrooms")]
        public async Task<List<Room>> GetApartmentRooms(int apartmentID)
        {
            return await service.GetApartmentRooms(apartmentID);
        }

        [HttpGet]
        [Route("getapartmentbyroomid")]
        public async Task<Apartment> GetApartmentByRoomID(int roomID)
        {
            return await service.GetApartmentByRoomID(roomID);
        }

        [HttpGet]
        [Route("getuserbyroomid")]
        public async Task<User> GetUserByRoomID(int roomID)
        {
            return await service.GetUserByRoomID(roomID);
        }

        #endregion
        #region
        [HttpPost]
        public async Task<Room> AddRoom([FromBody]Room room)
        {
            return await service.AddRoom(room);
        }
        #endregion
    }
}
