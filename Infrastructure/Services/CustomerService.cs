using Dapper;
using Infrastructure.Interface;
using Domain.Entities;
using Infrastructure.Data;
namespace Infrastructure.Services;

public class CustomerService : ICustomerService
{
    private readonly DataContext context = new DataContext();
    public List<Customers> GetAllCustomers()
    {
        using var connection = context.GetDbConnection();
        var sql = "select * from customers";
        var result = connection.Query<Customers>(sql).ToList();
        return result;
    }
    public void CreateCustomer(Customers customers)
    {
        using var connection = context.GetDbConnection();
        var sql = @"insert into customers (fullName, email) values (@Name, @email)";
        var result = connection.Execute(sql, customers);
    }
    public void UpdateCustomer(Customers customers)
    {
        using var connection = context.GetDbConnection();
        var sql = @"update customers set fullName = @Name, email = @email where id = @id";
        var result = connection.Execute(sql, customers);
    }
    public void DeleteCustomer(int id)
    {
        using var connection = context.GetDbConnection();
        var sql = "delete from customers where id = @id";
        var result = connection.Execute(sql, new {id = id });
    } 
}
