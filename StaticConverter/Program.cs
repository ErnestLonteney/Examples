namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var converter1 = new Converter("Volodymyr");
            var converter2 = new Converter("Oleg");

            converter1.ConvertDollarsToHrnWithLogs(500);
            converter1.ConvertDollarsToHrnWithLogs(1000);
            converter1.ConvertHrnToDollarsWithLogs(10_000);

            converter2.ConvertDollarsToHrnWithLogs(300);
            converter2.ConvertDollarsToHrnWithLogs(4000);
            converter2.ConvertHrnToDollarsWithLogs(50_000);


            var grns = Converter.ConvertDollarsToHrn(500);

            Console.WriteLine($"Sum in hrn {grns}");


            Converter.EuroRate = 47;
            Converter.DollarRate = 42.5;

            converter1.ConvertDollarsToHrnWithLogs(500);
            converter1.ConvertDollarsToHrnWithLogs(1000);
            converter1.ConvertHrnToDollarsWithLogs(10_000);

            converter2.ConvertDollarsToHrnWithLogs(300);
            converter2.ConvertDollarsToHrnWithLogs(4000);
            converter2.ConvertHrnToDollarsWithLogs(50_000);

            for (int i = 0; i < converter1.OperationLogs.Length; i++)
                if (converter1.OperationLogs[i] != null)
                    Console.WriteLine(converter1.OperationLogs[i]);

            for (int i = 0; i < converter2.OperationLogs.Length; i++)
                if (converter2.OperationLogs[i] != null)
                    Console.WriteLine(converter2.OperationLogs[i]);


            var grns2 = Converter.ConvertDollarsToHrn(500);
            var dollars = Converter.ConvertHrnToDollars(10_000);

            Console.WriteLine($"Dollars={dollars}");

            Console.WriteLine($"Sum in hrn {grns2}");

            Converter.EuroRate = 46;
            Converter.DollarRate = 49;

           var hrn3 = Converter.ConvertEuroToHrn(1000);
           Console.WriteLine($"Hrn = {hrn3}");
        }
    }
}
