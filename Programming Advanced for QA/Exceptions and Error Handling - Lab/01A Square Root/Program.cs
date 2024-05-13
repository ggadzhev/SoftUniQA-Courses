namespace _01A_Square_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            try
            {
                number = IsNumberNegative(number);
                double result = Math.Sqrt(number);
                Console.WriteLine(result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }

        static double IsNumberNegative(double input)
        {
            if (input < 0)
            {
                throw new ArgumentException("Invalid number.");
            }

            return input;

        }

    }
}
