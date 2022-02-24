 using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //// value types(değer tipi)
            //// int, decimal, float, enum, boolean, char, double, byte, struct

            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;


            //Console.WriteLine("Sayi 1 : " +sayi1);

            //// referance types (referans tipi)
            //// class, interface, delegate, strings, arrays => (even if their elements are value types)

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayilar1[0]" + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirtName = "Serdar";
            person2 = person1;
            person1.FirtName = "Turk";         

           // Console.WriteLine(person2.FirtName);

            Customer customer = new Customer();
            customer.FirtName = "Salih";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirtName = "Kenan";

            Person person3 = customer;
            customer.FirtName = "Komutan";
            //Console.WriteLine(person3.FirtName);
            //  Console.WriteLine(((Customer)person3).CreditCardNumber);
            // Buradaki Customer Classı int string gibi sadece bir tip. Burada biz neye boxing yapacağımızı belirtmiş oluyoruz.

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);  // Bu bize aynı kodu farklı nesneler için çalıştırabilmemize imkan sunuyor.
        }
    }

    class Person    //base class (base sınıf)
    {
        public int Id { get; set; }
        public string FirtName { get; set; }
        public string LastName { get; set; }

    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirtName);
        }
    }
}
