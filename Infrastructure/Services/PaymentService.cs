using Dapper;
using Infrastructure.Interface;
using Domain.Entities;
using Infrastructure.Data;
namespace Infrastructure.Services;

public class PaymentService : IPaymentService
{
    private readonly DataContext context = new DataContext();

    public List<Payments> GetAllPayments()
    {
        using var connection = context.GetDbConnection();
        var sql = "select * from payments";
        var result = connection.Query<Payments>(sql).ToList();
        return result;
    }
    public void CreatePayment(Payments payments)
    {
        using var connection = context.GetDbConnection();
        var sql = @"insert into payments (bookingId,amount,paymentDate,paymentMethod) values (@bookingId,@amount,@paymentDate,@paymentMethod)";
        var result = connection.Execute(sql, new
        {
            payments.BookingId,
            payments.Amount,
            payments.PaymentDate,
            payments.PaymentMethod
        });
    }
    public void UpdatePayment(Payments payments)
    {
        using var connection = context.GetDbConnection();
        var sql = @"update payments set bookingId = @bookingId,amount = @amount,paymentDate = @paymentDate,paymentMethod = @paymentMethod where id = @id";
        var result = connection.Execute(sql, payments);
    }
    public void DeletePayment(int id)
    {
        using var connection = context.GetDbConnection();
        var sql = "delete from payments where id = @id";
        var result = connection.Execute(sql, new {id = id });
    }
}
