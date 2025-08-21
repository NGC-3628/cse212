using System;
using System.Drawing;
using System.Security.AccessControl;

public static class upperNotifications{
    public static int[] array;
    public static void Run(){
        Console.WriteLine("Enter the number of values to add in the array");
        int userNumberSize = Convert.ToInt32(Console.ReadLine());

        //int size = userNumberSize;
        array = ArrayCreation(userNumberSize);


        for(int i = 0; i < userNumberSize; i++){
            Console.WriteLine("Enter a positive number");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            array[i] = userNumber;
        }
    
        foreach(int num in array){
            Console.Write(num+" ");
        }
        Console.WriteLine();

    }

    public static int[] ArrayCreation(int userNumberSize){
        return new int[userNumberSize];
    }
}