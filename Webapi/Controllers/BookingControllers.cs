using Microsoft.AspNetCore.Mvc;
using Dapper;
using Infrastructure.Data;
using Infrastructure.Interface;
using Infrastructure.Services;
using Domain.Entities;
namespace Webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookingControllers
{
    private IBookingService bookingService = new BookingService();
    [HttpGet]
    public List<Bookings> GetAllBookings()
    {
        var result = bookingService.GetAllBookings();
        return result;
    }
    [HttpPost]
    public void CreateBooking(Bookings bookings)
    {
        bookingService.CreateBooking(bookings);
    }
    [HttpPut]
    public void UpdateBooking(Bookings bookings)
    {
        bookingService.UpdateBooking(bookings);
    }
    [HttpDelete]
    public void DeleteBooking(int id)
    {
        bookingService.DeleteBooking(id);
    }
}
