using System;


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
}