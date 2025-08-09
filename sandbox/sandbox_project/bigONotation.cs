using System;
using System.Runtime.Versioning;


public static class bigONotation{

/*
    public static void Run()
    {
        int size = 10;
        int[] array = CreateArray(size);
        array = GenerateRandomNumbers(array);

        Console.WriteLine("Numeros generados");
        foreach(int num in array)
        {
            Console.Write(num+" ");
        }
        Console.WriteLine();
    }

    public static int[] CreateArray(int size)
    {
        return new int[size];
    }

    public static int[] GenerateRandomNumbers(int[] array)
    {
        Random random = new Random();
        
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
        }

        return array;
    }
*/
//hijo
public static int[] numbers;


//information to be dipslayed in the main program.
    public static void Run()
    {
        //Calling the array creation method. Calling the random numbers maker method.
    int size = 10;
    numbers = ArrayCreation(size); // <-- ahora asigna al campo estático
    //int[] array = CreateArray(size); This is a local variable that is shadowing the static variable.
    numbers = RandomNumMaker(numbers);

    foreach (int num in numbers)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
    }

    public static int[] ArrayCreation(int size)
    {
        return new int[size];
    }

    public static int[] RandomNumMaker(int [] array)
    {
        Random rand = new Random();

        //crear los valores random
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 101);
        }

        return array;
    }
}