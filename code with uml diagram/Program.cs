using System;
using System.Collections.Generic;
using System.Xml.Linq;

public class Employee
{
    public int ID;
    public int GetID()
    {
        return ID;
    }
    private void SetID(int id)
    {
        ID = id;
    }
    public string Name;
    public string GetName()
    {
        return Name;
    }
    private void SetName(string name)
    {
        Name = name; // Corrected assignment
    }
    public string Position;
    public string GetPosition()
    {
        return Position;
    }
    private void SetPosition(string position)
    {
        Position = position; // Corrected assignment
    }
    public decimal HourlySalary;
    public decimal GetHourlySalary()
    {
        return HourlySalary;
    }
    private void SetHourlySalary(decimal hourlySalary)
    {
        HourlySalary = hourlySalary; // Corrected assignment
    }

    internal void DisplayInfo()
    {
        Console.WriteLine($"ID: {ID}, Name: {Name}, Position: {Position}, Hourly Salary: {HourlySalary:C}");
    }
}

public class Food
{
    public string Name;
    public string GetName()
    {
        return Name;
    }
    private void SetName(string name)
    {
        Name = name; // Corrected assignment
    }
    public decimal Price;
    public decimal GetPrice()
    {
        return Price;
    }
    private void SetPrice(decimal price)
    {
        Price = price; // Corrected assignment
    }
    public decimal Storage;
    public decimal GetStorage()
    {
        return Storage;
    }
    private void SetStorage(decimal storage)
    {
        Storage = storage;
    }
    public Food(string name, decimal price, decimal storage)
    {
        Name = name;
        Price = price;
        Storage = Storage;
    }
}

public class Drink
{
    public string Name;
    public string GetName()
    {
        return Name;
    }
    private void SetName(string name)
    {
        Name = name; // Corrected assignment
    }
    public decimal Price;
    public decimal GetPrice()
    {
        return Price;
    }
    private void SetPrice(decimal price)
    {
        Price = price; // Corrected assignment
    }
    public decimal Storage;
    public decimal GetStorage()
    {
        return Storage;
    }
    private void SetStorage(decimal storage)
    {
        Storage = storage;
    }
    public Drink(string name, decimal price, decimal storage)
    {
        Name = name;
        Price = price;
        Storage = storage;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
       {
           new Employee { ID = 001, Name = "Ahmet", Position = "Server", HourlySalary = 30.00m },
           new Employee { ID = 002, Name = "Mehmet", Position = "Store Manager", HourlySalary = 50.00m },
           new Employee { ID = 003, Name = "Cemil", Position = "Server", HourlySalary = 35.00m },
           new Employee { ID = 004, Name = "Sercan", Position = "Kitchen Manager", HourlySalary = 40.00m },
           new Employee { ID = 005, Name = "Eray", Position = "Cleaner", HourlySalary = 25.00m }


       };

        List<Food> foods = new List<Food>
        {
            new Food("Pizza", 12.99m, 75),
            new Food("Burger", 8.49m, 45),
            new Food("Pasta", 10.59m, 97)
        };

        // Creating a list of drink items
        List<Drink> drinks = new List<Drink>
        {
            new Drink("Coke", 1.99m, 175),
            new Drink("Juice", 2.49m, 130),
            new Drink("Water", 0.99m, 250)
        };

        // Menu to select between Employee, Food, or Drink
        while (true)
        {
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Search for Employee");
            Console.WriteLine("2. Search for Food");
            Console.WriteLine("3. Search for Drink");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                // Searching for employee by name
                Console.Write("Enter employee name: ");
                string inputName = Console.ReadLine();

                Employee foundEmployee = employees.Find(emp => emp.Name.Equals(inputName, StringComparison.OrdinalIgnoreCase));

                if (foundEmployee != null)
                {
                    foundEmployee.DisplayInfo(); // Displaying employee info
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            }
            else if (menuChoice == "2")
            {
                // Searching for food by name
                Console.Write("Enter food name: ");
                string inputFood = Console.ReadLine();

                Food foundFood = foods.Find(food => food.Name.Equals(inputFood, StringComparison.OrdinalIgnoreCase));

                if (foundFood != null)
                {
                    Console.WriteLine($"Food: {foundFood.Name}, Price: {foundFood.Price:C}, Storage:, {foundFood.Storage}");
                }
                else
                {
                    Console.WriteLine("Food not found.");
                }
            }
            else if (menuChoice == "3")
            {
                // Searching for drink by name
                Console.Write("Enter drink name: ");
                string inputDrink = Console.ReadLine();

                Drink foundDrink = drinks.Find(drink => drink.Name.Equals(inputDrink, StringComparison.OrdinalIgnoreCase));

                if (foundDrink != null)
                {
                    Console.WriteLine($"Drink: {foundDrink.Name}, Price: {foundDrink.Price:C}, Storage: {foundDrink.Storage}");
                }
                else
                {
                    Console.WriteLine("Drink not found.");
                }
            }
            else if (menuChoice == "4")
            {
                Console.WriteLine("Exiting program.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}   
