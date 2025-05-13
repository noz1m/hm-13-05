using Dapper;
using Infrastructure.Interface;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Services;

public class BookingService : IBookingService
{
    private readonly DataContext context = new DataContext();

    public List<Bookings> GetAllBookings()
    {
        using var connection = context.GetDbConnection();
        var sql = "select * from bookings";
        var result = connection.Query<Bookings>(sql).ToList();
        return result;
    } 
    public void CreateBooking(Bookings bookings)
    {
        using var connection = context.GetDbConnection();
        var sql = @"insert into bookings (checkIn, checkOut, roomId, customerId) values (@checkIn, @checkOut, @roomId, @customerId)";
        var result = connection.Execute(sql, bookings);
    }
    public void UpdateBooking(Bookings bookings)
    {
        using var connection = context.GetDbConnection();
        var sql = @"update bookings set checkIn = @checkIn, checkOut = @checkOut, roomId = @roomId, customerId = @customerId where id = @id";
        var result = connection.Execute(sql, bookings);
    }
    public void DeleteBooking(int id)
    {
        using var connection = context.GetDbConnection();
        var sql = "delete from bookings where id = @id";
        var result = connection.Execute(sql, new {id = id });
    }
}
