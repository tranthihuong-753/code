using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// khai báo 
class Customer
{
    public string CustomerID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
}

class Order
{
    public string OrderID { get; set; }
    public string CustomerID { get; set; }
    public string Product { get; set; }
    public int Quantity { get; set; }
}// nhập hàm lớp Customer 
class Program
{
    static void NhapCustomer(Customer customer)
    {
        try
        {
            Console.Write("Enter CustomerID: ");
            customer.CustomerID = Console.ReadLine();
            while (customer.CustomerID.Length != 10)
            {
                Console.WriteLine("CustomerID must be exactly 10 characters.");
                customer.CustomerID = Console.ReadLine();
            }
            Console.Write("Enter Name: ");
            customer.Name = Console.ReadLine();

            Console.Write("Enter Address: ");
            customer.Address = Console.ReadLine();

            Console.Write("Enter Email: ");
            customer.Email = Console.ReadLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void NhapOrder(Order order)
    {
        try
        {
            Console.Write("Enter OrderID: ");
            order.OrderID = Console.ReadLine();
            if (order.OrderID.Length != 10)
                throw new FormatException("OrderID must be exactly 10 characters.");

            Console.Write("Enter CustomerID: ");
            order.CustomerID = Console.ReadLine();
            if (order.CustomerID.Length != 10)
                throw new FormatException("CustomerID must be exactly 10 characters.");

            Console.Write("Enter Product: ");
            order.Product = Console.ReadLine();
            if (order.Product.Length > 50)
                throw new FormatException("Product name must not exceed 50 characters.");

            Console.Write("Enter Quantity: ");
            order.Quantity = int.Parse(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void Main(string[] args)
    {
        Customer customer = new Customer();
        NhapCustomer(customer);
        Console.WriteLine($"Customer Info: {customer.CustomerID}, {customer.Name}, {customer.Address}, {customer.Email}");

        Order order = new Order();
        NhapOrder(order);
        Console.WriteLine($"Order Info: {order.OrderID}, {order.CustomerID}, {order.Product}, {order.Quantity}");
    }
    // câu 3 
    static int InputInt_TryCatch()
    {
        Console.Write("n = ");
        int n;
        try
        {
            n = int.Parse(Console.ReadLine());
            if (n < 2 || n > 10)
            {
                Console.WriteLine("n la so nguyen duong tu 2 den 10.");
                Console.WriteLine("Vui long nhap lai.");
                InputInt_TryCatch();
            }
            return n;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            InputInt_TryCatch();
        }
        return 0;
    }
}