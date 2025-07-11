using System;
using System.Net;


public static class changeOrder
{
    public static void Run()
    {
        /// This sub-program will re arrange an array following user imput.
        /// if user enter number 2 the array will be displayed this way:
        /// 3,4,5,6,7,8,9,10,1,2
        /// 
        /*
        var arrayNumbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int userImput = 0;

        Console.WriteLine("Enter a number");
        if (userImput < 10)
        {
            userImput = int.Parse(Console.ReadLine());
        }
        else
            Console.WriteLine("Invalid imput. It shouldn't be greater than 20.");
        //int userImput = Convert.ToInt32(Console.ReadLine());

        int[] userArray = new int[userImput];
        for (int i = 0; i < userImput; i++)
        {
            userArray[i] = i + 1;
        }

        foreach (int n in userArray)
        {
            Console.WriteLine($"{n} ");
        }
        Console.WriteLine();


        /*var newPosition = Changes(arrayNumbers);
        Console.WriteLine($"The array is now like this {string.Join(", ", newPosition)}");*/
        var arrayNumbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int userImput = 0;

        Console.Write("Enter a number: ");
        try
        {
            userImput = int.Parse(Console.ReadLine());
            if (userImput > arrayNumbers.Length)
            {
                throw new Exception("The number must be less than the Array Numbers");

            }
            int[] userArray = new int[userImput];

            for (int i = 0; i < userImput; i++)
            {
                userArray[i] = arrayNumbers[i];
            }

            Console.WriteLine("Your array:");
            foreach (int n in userArray)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();

            //second part
            int remainingNums = arrayNumbers.Length - userImput;
            int[] restNumArray = new int[remainingNums];
            for (int i = 0; i < remainingNums; i++)
            {
                restNumArray[i] = arrayNumbers[userImput + i];
            }


            Console.WriteLine("The other array is:");
            foreach (int n in restNumArray)
            {
                Console.Write($" {n}");
            }
            Console.WriteLine();

            Console.WriteLine($"The new full array is: {string.Join(", ", restNumArray)}, {string.Join(", ", userArray)}");


        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid imput");
        }




    }


    //public static int[] Changes();

}