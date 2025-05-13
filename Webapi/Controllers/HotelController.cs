using Microsoft.AspNetCore.Mvc;
using Dapper;
using Infrastructure.Data;
using Infrastructure.Interface;
using Infrastructure.Services;
using Domain.Entities;
namespace Webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HotelController
{
    private IHotelService hotelService = new HotelService();
    [HttpGet]
    public List<Hotels> GetAllHotels()
    {
        var result = hotelService.GetAllHotels();
        return result;
    }
    [HttpPost]
    public void CreateHotel(Hotels hotels)
    {
        hotelService.CreateHotel(hotels);
    }
    [HttpPut]
    public void UpdateHotel(Hotels hotels)
    {
        hotelService.UpdateHotel(hotels);
    }
    [HttpDelete]
    public void DeleteHotel(int id)
    {
        hotelService.DeleteHotel(id);
    }
}
