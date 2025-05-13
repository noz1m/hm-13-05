using Domain.Entities;

namespace Infrastructure.Interface;

public interface ICustomerService
{
    public List<Customers> GetAllCustomers();
    public void CreateCustomer(Customers customer);
    public void UpdateCustomer(Customers customer);
    public void DeleteCustomer(int id);
}
