using Domain.Entities;

namespace Infrastructure.Interface;

public interface IRoomService
{
    public List<Rooms> GetAllRooms();
    public void CreateRoom(Rooms room);
    public void UpdateRoom(Rooms room);
    public void DeleteRoom(int id);
}
