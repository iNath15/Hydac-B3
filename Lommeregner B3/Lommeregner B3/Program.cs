namespace Lommeregner_B3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("""
                
                1. +
                2. -
                3. *
                4. /

                Choose the operator you wish to use:
                """);

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine($"{choice} has been chosen.");

            Console.Write("Input your first value: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input your second value: ");
            int b = int.Parse(Console.ReadLine());

            Calculator calc = new Calculator();

            double sum = 0;

            switch (choice) {
                case 1:
                    sum = calc.Add(a, b);
                    break;
                case 2:
                    sum = calc.Subtract(a, b);
                    break;
                case 3:
                    sum = calc.Multiply(a, b);
                    break;
                case 4:
                    sum = calc.Divide(a, b);
                    break;
                default:
                    break;
            }

            Console.WriteLine($"The answer is {sum}");
        }
    }
}
