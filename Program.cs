// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Abstract;
using ConsoleApp1.Adapters;
using ConsoleApp1.Concrete;

BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
customerManager.Save(new Customer { DateOfBirth = new DateTime(2001, 5, 28), FirstName = "Ahmet Kerim", LastName = "Altun", NationalityId = "14879569100" });

Console.ReadLine();