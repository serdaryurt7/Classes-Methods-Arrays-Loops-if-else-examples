using System;

namespace Consturctors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() {Id = 1, FirstName = "Mert", LastName = "Lermioglu", City = "Istanbul" };
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Metin";
            customer3.LastName = "Ak";
            customer3.City = "Balıkesir";
            // Üstteki iki kullanım şekli de aynıdır.

            Customer customer2 = new Customer(2, "Serdar", "Yurtseven", "Istanbul");
            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        public Customer()
        {

        }
        //default constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id ;
            FirstName = firstName ;
            LastName = lastName ;
            City = city ;

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
// Consturcorlar method gibi çalışır
// Constructor yazmasak bile arkaplanda bir default constructor çalışır.