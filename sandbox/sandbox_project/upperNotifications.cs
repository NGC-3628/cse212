using System;
using System.Drawing;
using System.Security.AccessControl;

public static class upperNotifications{
    public static int[] array;
    public const string ErrorMessage = "Imput valid";
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
    
        Console.WriteLine("Do you want me to print the list of numbers?\nYes/No");
        string userRepoBool = Console.ReadLine()?.ToLower();
        while(userRepoBool != "yes" && userRepoBool != "no")
        {
            Console.WriteLine(ErrorMessage);
            Console.WriteLine("Do you want me to print the list of numbers?\nYes/No");
            userRepoBool = Console.ReadLine()?.ToLower();
        }

        if(userRepoBool == "yes"){
            Console.WriteLine("Here, printed numbers\n");
            foreach(int num in array)
            {
            Console.Write(num+" ");
            }
            Console.WriteLine();
        }
        else if(userRepoBool == "no"){
            Console.WriteLine("bye bye");
            return;
        }

        Console.WriteLine("Do you want me to order the numbers?\nYes/No");
        userRepoBool = Console.ReadLine()?.ToLower();
        while(userRepoBool != "yes" && userRepoBool != "no")
        {
            Console.WriteLine(ErrorMessage);
            Console.WriteLine("Do you want me to order the numbers?\nYes/No");
            userRepoBool = Console.ReadLine()?.ToLower();
        }

        if(userRepoBool == "yes"){
            upperNotifications.SortedArray(array);

            Console.WriteLine("here, arranged numbers from lower to higher\n");
            foreach(int num in array)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();
        }
    }

    public static int[] ArrayCreation(int userNumberSize){
        return new int[userNumberSize];
    }

    public static int[] SortedArray(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array;
    }
}