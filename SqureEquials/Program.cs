namespace ConsoleApp30
{
    internal class Program
    {
        static double GetDescriminant(double a, double b, double c)
        {
            return Math.Pow(b, 2) - (4 * a * c);
        }

        static string GetRoots(double a, double b, double c)
        {
            var deskriminant = GetDescriminant(a, b, c);
            if (deskriminant > 0)
            {
                var x1 = (-b + Math.Sqrt(deskriminant)) / (2 * a);
                var x2 = (-b - Math.Sqrt(deskriminant)) / (2 * a);
                return $"x1 = {x1}, x2 = {x2}";
            }
            else if (deskriminant == 0)
            {
                var x = -b / (2 * a);
                return $"x = {x}";
            }
            else
            {
                return "No real roots";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input A");
            string answer = Console.ReadLine();

            if (double.TryParse(answer, out double a))
            {
                Console.WriteLine("Input B");
                answer = Console.ReadLine();

                if (double.TryParse(answer, out double b))
                {
                    Console.WriteLine("Input C");
                    answer = Console.ReadLine();

                    if (double.TryParse(answer, out double c))
                    {
                       string result = GetRoots(a, b, c);
                       Console.WriteLine(result);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input C");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input B");
                }
            }
            else
            {
                Console.WriteLine("Invalid input A");
            }
        }
    }
}
