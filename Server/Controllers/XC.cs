namespace LexiconLMSBlazor.Server.Controllers
{
    public static class XC // X-Console class. För utskrift i konsolmiljö.
    {
        public static void ERR(string input) // Felmeddelande med gul textfärg.
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Environment.NewLine + "ERR>>> ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(input + Environment.NewLine);
            Console.ResetColor();
        }

        public static void INF(string input) // Information med blå textfärg.
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(Environment.NewLine + "INF>>> ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(input + Environment.NewLine);
            Console.ResetColor();
        }
    }
}