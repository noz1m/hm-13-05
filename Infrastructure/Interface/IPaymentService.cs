using Domain.Entities;

namespace Infrastructure.Interface;

public interface IPaymentService
{
    public List<Payments> GetAllPayments();
    public void CreatePayment(Payments payment);
    public void UpdatePayment(Payments payment);
    public void DeletePayment(int id);
}
