using Dapper;
using Infrastructure.Interface;
using Domain.Entities;
using Infrastructure.Data;
namespace Infrastructure.Services;

public class RoomService : IRoomService
{
    private readonly DataContext context = new DataContext();

    public List<Rooms> GetAllRooms()
    {
        using var connection = context.GetDbConnection();
        var sql = "select * from rooms";
        var result = connection.Query<Rooms>(sql).ToList();
        return result;
    }
    public void CreateRoom(Rooms rooms)
    {
        using var connection = context.GetDbConnection();
        var sql = @"insert into rooms (hotelId,roomNumber,capacity,pricePerNight) values (@hotelId,@roomNumber,@capacity,@pricePerNight)";  
        var result = connection.Execute(sql, new
        {
            rooms.HotelId,
            rooms.RoomNumber,
            rooms.Capacity,
            rooms.PricePerNight
        });
    }
    public void UpdateRoom(Rooms rooms)
    {
        using var connection = context.GetDbConnection();
        var sql = @"update rooms set hotelId = @hotelId,roomNumber = @roomNumber,capacity = @capacity,pricePerNight = @pricePerNight where id = @id";
        var result = connection.Execute(sql, rooms);
    }   
    public void DeleteRoom(int id)
    {
        using var connection = context.GetDbConnection();
        var sql = "delete from rooms where id = @id";
        var result = connection.Execute(sql, new {id = id });
    } 
}
