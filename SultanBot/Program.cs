// See https://aka.ms/new-console-template for more information

using SultanBot;

internal class Program
{
    public static void Main(string[] args)
    {
        var currencyBot = new CurrencyBot(ApiConstant.BOT_API);
        currencyBot.CreateCommands();
        currencyBot.StartReceiving();

        // Ожидаем нажатия клавиши до завершения программы
        Console.ReadKey();
    }
}