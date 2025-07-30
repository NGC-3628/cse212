using System;
<<<<<<< HEAD
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

=======



public static class chnageOrder{

    public static void Run()
    {

        /*
        var model = new int[]{1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
        int userOpt;

        Console.WriteLine("Enter a positive number. Not bigger than 20");
        while(!int.TryParse(Console.ReadLine(), out userOpt) || userOpt < 0 || userOpt > 20)
        {
            Console.WriteLine("The number is not valid\nTry again");
        }

        var userArray1 = new int[userOpt];  //Length of array
        var userArray2 = new int[model.Length-userOpt]; //length of array

        for (int i = 0; i < userOpt; i++)
        {
            userArray1[i] = i+1; //stroing all values of i in values of i.
        }

        for (int i = 0; i < model.Length-userOpt; i++)
        {
            userArray2[i] = model[userOpt+i];
        }
        /*
        foreach(int n in userArray1)
        {
            Console.Write($" {n}");
        }
        Console.WriteLine();

        foreach(int n in userArray2)
        {
            Console.Write($" {n}");
        }
        Console.WriteLine();
        

        Console.WriteLine($"The array is now {string.Join(", ", userArray1)}; {string.Join(", ", userArray2)}");
        */

        /// rotate right variable
        ///r
        ///

        int userRepo;
        var model = new []{1,2,3,4,5,6,7,8,9,10};
        int max = model[0];
        for (int i = 1; i < model.Length; i++)
        {
            if(model[i] > max)
            {
                max = model[i];
            }
        }


        Console.WriteLine("enter a number");
        while (!int.TryParse(Console.ReadLine(), out userRepo)|| userRepo > max || userRepo < 0)
        {
            Console.WriteLine("Invalid number. Try again");
        }

        //first array with number from 0 to typed number by the user.
        var a = new int[userRepo];
        for(int i = 0; i < userRepo; i++)
                {
            a[i] = i+1;
        }

        //second array. Conatins the rest of the numbers the user didn't type.
        var b = new int[model.Length-userRepo];
        for(int i = 0; i < b.Length; i++)
        {
            b[i] = model[userRepo++];
        }

        Console.WriteLine($"The biggest number in the main array is {max}");
        Console.WriteLine($"The array the user made is {string.Join(", ", b)} and the rest is {string.Join(", ", a)}");



        


    }
>>>>>>> 3f03222 (hello)
}