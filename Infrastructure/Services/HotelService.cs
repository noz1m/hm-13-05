using Dapper;
using Infrastructure.Interface;
using Domain.Entities;
using Infrastructure.Data;
namespace Infrastructure.Services;

public class HotelService : IHotelService
{
    private readonly DataContext context = new DataContext();

    public List<Hotels> GetAllHotels()
    {
        using var connection = context.GetDbConnection();
        var sql = "select * from hotels";
        var result = connection.Query<Hotels>(sql).ToList();
        return result;
    }
    public void CreateHotel(Hotels hotels)
    {
        using var connection = context.GetDbConnection();
        var sql = @"insert into hotels (name, city) values (@name, @city)";
        var result = connection.Execute(sql, new
        {
            hotels.Name,
            hotels.City
        });
    }
    public void UpdateHotel(Hotels hotels)
    {
        using var connection = context.GetDbConnection();
        var sql = @"update hotels set name = @name, city = @city where id = @id";
        var result = connection.Execute(sql, hotels);
    }
    public void DeleteHotel(int id)
    {
        using var connection = context.GetDbConnection();
        var sql = "delete from hotels where id = @id";
        var result = connection.Execute(sql, new {id = id });
    }
}
