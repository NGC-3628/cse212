using System;
using System.Linq.Expressions;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1. run first program\n2. Create array program\n3. Dynamic arrays\n4. Arrays with random numbers");

        int userOption = Convert.ToInt32(Console.ReadLine());

        switch (userOption)
        {
            case 1:
                Console.WriteLine("\n================\nDifferent ways to see the arrays\n================");
                first_sandbox.Run();
                break;

            case 2:
                Console.WriteLine("\n================\nCreating new arrays\n================");
                newArray.Run();

                break;

            case 3:
                Console.WriteLine("\n================\nDynamic Arrays with user interaction\n================");
                chnageOrder.Run();
                break;

            case 4:
                Console.WriteLine("\n================\nArrays with random numbers\n================");
                bigONotation.Run();
                orderValues.Run();

                break;
        }
    }
}