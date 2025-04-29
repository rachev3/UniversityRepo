using PizzaRes.Models;

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

    if (name == "Pizza Boss` Pizza")
    {
        BossPizza bossPizza = new BossPizza(size);
        Order order = new Order(bossPizza, count, day);

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
    else if (name == "Pizza Margarita")
    {
        MargaritaPizza margaritaPizza = new MargaritaPizza(size);
        Order order = new Order(margaritaPizza, count, day);

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
    else
    {
        throw new ArgumentException("Wrong pizza name. Only Pizza Margarita and Pizza Boss` Pizza allowed.");
    }
}
Console.WriteLine();
Console.WriteLine("Output:");
foreach(var order in orders)
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