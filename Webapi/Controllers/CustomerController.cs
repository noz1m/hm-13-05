using Microsoft.AspNetCore.Mvc;
using Dapper;
using Infrastructure.Data;
using Infrastructure.Interface;
using Infrastructure.Services;
using Domain.Entities;
namespace Webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController
{
    private ICustomerService customerService = new CustomerService();
    [HttpGet]
    
    public List<Customers> GetAllCustomers()
    {
        var result = customerService.GetAllCustomers();
        return result;
    }
    [HttpPost]
    public void CreateCustomer(Customers customers)
    {
        customerService.CreateCustomer(customers);
    }
    [HttpPut]
    public void UpdateCustomer(Customers customers)
    {
        customerService.UpdateCustomer(customers);
    }
    [HttpDelete]
    public void DeleteCustomer(int id)
    {
        customerService.DeleteCustomer(id);
    }
}
