namespace Domain.Entities;

public class Bookings
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public int RoomId { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
}
