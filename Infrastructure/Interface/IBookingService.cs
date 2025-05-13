using Domain.Entities;

namespace Infrastructure.Interface;

public interface IBookingService
{
    public List<Bookings> GetAllBookings();
    public void CreateBooking(Bookings bookings);
    public void UpdateBooking(Bookings bookings);
    public void DeleteBooking(int id);
}
