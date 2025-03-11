using BankAccount;

internal class Program
{
    public static void Main(string[] args)
    {
        User user = new("Gosho", 100, "BGN");

        user.GetUserInfo();
        Console.WriteLine();

        SpecialUser specialUser = new("Pesho", 108, "USD");
        specialUser.GetUserInfo();
        Console.WriteLine();

        specialUser.Balance = CurrencyConverter.ConvertCurrency(specialUser.Balance, specialUser.Balance_Currency, "BGN");
        specialUser.Balance_Currency = "BGN";

        specialUser.GetUserInfo();

    }
}