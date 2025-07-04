using System;
using System.Linq.Expressions;
using System.Collections.Generic;

public static class first_sandbox{
    public static void Run()
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine("hello\nThere are two ways to create an array");

        Console.WriteLine("What do you want to do?");

        
        var arrayVersion1 = new int [4];
        arrayVersion1[0] = 1;
        arrayVersion1[1] = 2;
        arrayVersion1[2] = 3;
        arrayVersion1[3] = 4;


        var arrayVersion2 = new [] {1,2,3};


        //CREATING A DYNAMIC ARRAY
        // we use a list to create it

        var arrayDyanmicV1 = new List<int> ();

        arrayDyanmicV1.Add(1);
        arrayDyanmicV1.Add(2);
        arrayDyanmicV1.Add(3);


        //VERSION 2
        var arrayDyanmicV2 = new List<int> {1,2,3};





        //Now, in oirder to print the numbers inside the array we have three options:
        // for each loop
/*
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        //using a String join line 
        Console.WriteLine(string.Join(", ", numbers));

        //uisng a Foreach Array
        Array.ForEach(numbers, Console.WriteLine);
        
        */
        Console.WriteLine("Choose the method you want to use to print the array");
        Console.WriteLine("1. Foreach loop\n2. String Join line\n3. Foreach Array");
        int usermethodChoose = Convert.ToInt32(Console.ReadLine());

        switch(usermethodChoose)
        {
            case 1:
                foreach (int number in arrayVersion1)
                {
                    Console.WriteLine($"\n{number}");
                }

            break;
            case 2: 
                Console.WriteLine(string.Join(", ", arrayVersion1));

            break;
            case 3:
                Array.ForEach(arrayVersion1, Console.WriteLine);
            break;
            default:
                Console.WriteLine("you chose nothing");
            break;
        }

        


    }
}