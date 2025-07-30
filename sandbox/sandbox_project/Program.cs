using System;
using System.Linq.Expressions;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What do you want to do?");
<<<<<<< HEAD
        Console.WriteLine("1. run first program\n2. Create array program\n3. Dynamic arrays");
=======
        Console.WriteLine("1. run first program\n2. Create array program\n3. Change the array");
>>>>>>> 3f03222 (hello)
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
<<<<<<< HEAD
                break;

            case 3:
                Console.WriteLine("\n================\nDynamic Arrays with user interaction\n================");
                changeOrder.Run();
                break;
=======
            break;

            case 3:
                Console.WriteLine("\n================\nChanging the array according to the user\n================");
                chnageOrder.Run();
            break;
>>>>>>> 3f03222 (hello)
        }
    }
}