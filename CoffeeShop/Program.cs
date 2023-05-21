using CoffeeShop.Abstract;
using CoffeeShop.Adapters;
using CoffeeShop.Concrete;
using CoffeeShop.Entities;
using System;

namespace CoffeeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Abdullah Emin";
            customer.LastName = "Tatar";
            customer.DateOfBirth = new DateTime(1985,1,1);
            customer.NationalityId = "1234567890";

            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(customer);
        }
    }
}