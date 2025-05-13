using Domain.Entities;

namespace Infrastructure.Interface;

public interface IHotelService
{
    public List<Hotels> GetAllHotels();
    public void CreateHotel(Hotels hotel);
    public void UpdateHotel(Hotels hotel);
    public void DeleteHotel(int id);
}
