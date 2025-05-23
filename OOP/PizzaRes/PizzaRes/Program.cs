﻿using PizzaRes.Models;

List<Order> orders = new List<Order>();
List<Day> days = new List<Day>();

string command;



while ((command = Console.ReadLine()) != "end")
{
    string[] commandParts = command.Split(' ');

    if (commandParts.Length > 6 || commandParts.Length < 5)
    {
        throw new ArgumentException("Wrong command.");
    }

    if (!DateOnly.TryParse(commandParts[^1], out DateOnly day))
    {
        throw new ArgumentException("Invalid date format. Expected dd.MM.yyyy");
    }

    string size = commandParts[^2];
    if (!int.TryParse(commandParts[^3], out int count))
    {
        throw new ArgumentException("Invalid count. Must be a number.");
    }

    string name = string.Join(" ", commandParts[..^3]);

    Pizza pizza = CreatePizza(name, size, count);
    Order order = new Order(pizza, day);

    Day existingDay = days.FirstOrDefault(d => d.Date == day);
    if (existingDay == null)
    {
        Day newDay = new Day(day);
        newDay.AddOrder(order);
        days.Add(newDay);
    }
    else
    {
        existingDay.AddOrder(order);
    }

    orders.Add(order);
}
Console.WriteLine();
Console.WriteLine("Output:");
foreach (var order in orders)
{
    Console.WriteLine();
    order.Info();
}
Console.WriteLine();
Console.WriteLine("Cash register reset:");
Console.WriteLine();
foreach (var day in days)
{
    day.Info();
    Console.WriteLine();
}

Pizza CreatePizza(string name, string size, int count)
{
    return name switch
    {
        "Pizza Boss` Pizza" => new BossPizza(size, count),
        "Pizza Margarita" => new MargaritaPizza(size, count),
        _ => throw new ArgumentException("Wrong pizza name. Only Pizza Margarita and Pizza Boss` Pizza allowed.")
    };
}