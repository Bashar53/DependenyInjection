public interface ICustomerDataAcess
{
    string GetCustomerName(int id);
}
public class CustomerDataAccess : ICustomerDataAcess
{
    public CustomerDataAccess()
    {
        
    }
    public string GetCustomerName(int id)
    {
        Console.WriteLine("Dummy Customer Name");
        return "";
    }

}
public class CustomerBusinessLogic
{
    ICustomerDataAcess _customerDataAcess;
    public CustomerBusinessLogic(ICustomerDataAcess customerDataAcess)
    {
        _customerDataAcess = customerDataAcess;
    }
    public string ProcessCustomerData(int id)
    {
        return _customerDataAcess.GetCustomerName(id);
    }
}
public class CustomerService
{
    CustomerBusinessLogic _customerBusinessLogic;
    public CustomerService()
    {
        _customerBusinessLogic = new CustomerBusinessLogic( new CustomerDataAccess());
    }
    public string GetCustomerName(int id)
    {
        return _customerBusinessLogic.ProcessCustomerData(id);

    }
}
public class Program
{ 
    static void Main(string[] args)
    {
        CustomerService customerService = new CustomerService();
        customerService.GetCustomerName(5);
    }
}


