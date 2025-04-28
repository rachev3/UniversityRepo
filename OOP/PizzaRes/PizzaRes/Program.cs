using PizzaRes.Models;

List<Day> days = new List<Day>();

string command = "";

while (command != "end")
{
    command = Console.ReadLine();
    string[] commandParts = command.Split(' ');

    if (commandParts.Length > 6 || commandParts.Length < 5)
    {
        Console.WriteLine("Error command");
        break;
    }
    int counter = 1;
    for (int i = commandParts.Length - 1; i >= 0; i--)
    {
        if (counter == 1)
        {
        }
        else if (counter == 2)
        {

        }
        else if (counter == 3)
        { 
        }
        else()
    }

}