namespace OperationExercise 
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;

            int diff = a - b;

            int product = a * b;

            double quotient = a / b;

            int remainder = a % b;

            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {diff}");
            Console.WriteLine($"{a} * {b} is {product}");
            Console.WriteLine($"{a} / {b} is {quotient} remainder is {remainder}");


        }
    }
}
