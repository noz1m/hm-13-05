using Microsoft.AspNetCore.Mvc;
using Dapper;
using Infrastructure.Data;
using Infrastructure.Interface;
using Infrastructure.Services;
using Domain.Entities;
namespace Webapi.Controllers;

public class RoomController
{
    private IRoomService roomService = new RoomService();
    [HttpGet]
    public List<Rooms> GetAllRooms()
    {
        var result = roomService.GetAllRooms();
        return result;
    }
    [HttpPost]
    public void CreateRoom(Rooms rooms)
    {
        roomService.CreateRoom(rooms);
    }
    [HttpPut]
    public void UpdateRoom(Rooms rooms)
    {
        roomService.UpdateRoom(rooms);
    }
    [HttpDelete]
    public void DeleteRoom(int id)
    {
        roomService.DeleteRoom(id);
    }
}
