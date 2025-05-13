namespace Domain.Entities;

public class Rooms
{
    public int Id { get; set; }
    public int HotelId { get; set; }
    public string RoomNumber { get; set; }
    public int Capacity { get; set; }
    public decimal PricePerNight { get; set; }
}
