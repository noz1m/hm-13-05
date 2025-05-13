using Microsoft.AspNetCore.Mvc;
using Dapper;
using Infrastructure.Data;
using Infrastructure.Interface;
using Infrastructure.Services;
using Domain.Entities;
namespace Webapi.Controllers;


[ApiController]
[Route("api/[controller]")]
public class PaymentController
{
    private IPaymentService paymentService = new PaymentService();

    [HttpGet]
    public List<Payments> GetAllPayments()
    {
        var result = paymentService.GetAllPayments();
        return result;
    }
    [HttpPost]
    public void CreatePayment(Payments payments)
    {
        paymentService.CreatePayment(payments);
    }
    [HttpPut]
    public void UpdatePayment(Payments payments)
    {
        paymentService.UpdatePayment(payments);
    }
    [HttpDelete]
    public void DeletePayment(int id)
    {
        paymentService.DeletePayment(id);
    }
}
