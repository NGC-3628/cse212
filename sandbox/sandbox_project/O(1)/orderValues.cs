using System;

public class orderValues
{
    public static void Run()
    {
        if(bigONotation.numbers == null)
        {
            Console.WriteLine("Array hasn't been created yet.");
            return;
        }
        
        int[] sortedArray = (int[])bigONotation.numbers.Clone();

        //BUBBLE SORT METHOD
        for(int i = 0; i < sortedArray.Length -1; i++) //still wondering why there's a -1....
        {
            for(int j = 0; j < sortedArray.Length -i -1; j++)
            {
                if (sortedArray[j] > sortedArray[j+1])
                {
                    int temporal = sortedArray[j];
                    sortedArray[j] = sortedArray[j+1];
                    sortedArray[j+1] = temporal;
                }
            }
        }

        Console.WriteLine("Sorted Array");
        for(int i = 0; i < sortedArray.Length; i++)
        {
            Console.Write(sortedArray[i]+" ");
        }
        Console.WriteLine();




        //BUILT-IN METHOD
        /*Array.Sort(sortedArray);

        foreach(int a in sortedArray)
        {
            Console.Write(a+" ");
        }
        Console.WriteLine();
        */
    }
}