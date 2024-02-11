namespace Suzaal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter A Operator: ");
            string op = Console.ReadLine();

            Console.WriteLine("Enter Another Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            } else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            } else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            } else
            {
                Console.WriteLine("Please Enter A Valid Number");
            }
        }


    }
}