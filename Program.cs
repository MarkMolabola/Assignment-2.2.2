using System.ComponentModel;

namespace Assignment_2._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int int1, int2, int3;
                decimal dec1, dec2, dec3;
                float float1, float2, float3;
                bool continueProgram = true;
                Console.Clear();
                Console.WriteLine("What would you like to do? ");
                Console.WriteLine("1. Add two integers");
                Console.WriteLine("2. Add three decimals");
                Console.WriteLine("3. Multiply two floats(decimal)");
                Console.WriteLine("4. Multiply three floats(decimal)");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Please enter your choice (1-5): ");

                string choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You chose to add two integers.");
                        AddTwoIntegers(out int1, out int2);
                        break;
                    case "2":
                        Console.WriteLine("You chose to add three decimals.");
                        AddThreeDecimal(out dec1, out dec2, out dec3);
                        break;
                    case "3":
                        Console.WriteLine("You chose to multiply two floats.");
                        MultiplyTwoFloat(out float1, out float2);
                        break;
                    case "4":
                        Console.WriteLine("You chose to multiply three floats.");
                        MultiplyThreeFloat(out float1, out float2, out float3);
                        break;
                        
                    case "5":
                        Console.WriteLine("Exiting the program.");
                        continueProgram = false;
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
                if (continueProgram)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            } while (true);

            static void AddTwoIntegers(out int x, out int y)
            {
                Console.WriteLine("Enter first integer: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second integer: ");
                y = Convert.ToInt32(Console.ReadLine());
                int sum = Maths.Add(x, y);
                Console.WriteLine($"The sum of {x} and {y} is: {sum}");
            }
            static void AddThreeDecimal(out decimal x, out decimal y, out decimal z)
            {
                Console.WriteLine("Enter first decimal: ");
                x = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter second decimal: ");
                y = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter third decimal: ");
                z = Convert.ToDecimal(Console.ReadLine());
                decimal sum = Maths.Add(x, y, z);
                Console.WriteLine($"The sum of {x}, {y}, and {z} is: {sum}");
            }
            static void MultiplyTwoFloat(out float x, out float y)
            {
                Console.WriteLine("Enter first float: ");
                x = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter second float: ");
                y = Convert.ToSingle(Console.ReadLine());
                float product = Maths.Mulptiply(x, y);
                Console.WriteLine($"The product of {x} and {y} is: {product}");
            }
            static void MultiplyThreeFloat(out float x, out float y, out float z)
            {
                Console.WriteLine("Enter first float: ");
                x = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter second float: ");
                y = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter third float: ");
                z = Convert.ToSingle(Console.ReadLine());
                float product = Maths.Multiply(x, y, z);
                Console.WriteLine($"The product of {x}, {y}, and {z} is: {product}");
            }







        }
    }
}
