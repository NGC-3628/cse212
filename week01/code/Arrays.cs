public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    /// 
    /// 
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        double[] multiples = new double[length];

        for (int i = 1; i <= length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples; 
        ///
        /// Console.WriteLine("Enter one number to know its multiple");
        /// int userNumber = Convert.ToInt32(Console.WriteLine());
        /// 
        /// List<int> result = new();
        /// for(int i = 1; i <= userNumber; i++)
        /// {
        ///     if(userNumber % i == 0)
        ///     {
        ///         result.Add(i);
        ///     }
        /// }
        /// return result;
        /// 
        /// Console.WriteLine($"The multuples of {userNumber} are {string.Join(", ", result)}");
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Determine the number of elements to move. This is given by the amount parameter.
        // We also need to know how many elements will remain at the start of the list.
        int countOfElementsToKeepAtStart = data.Count - amount;

        // Step 2: Identify and copy the elements from the end of the list that need to be moved to the front.
        // We can get this range of elements starting from the 'rotation of elements'.
        // For a List, GetRange() is an efficient way to copy a section of the list.
        List<int> elementsToMove = data.GetRange(countOfElementsToKeepAtStart, amount);

        // Step 3: Remove those same elements from the end of the list.
        // Now the list only contains the first part (e.g., {1, 2, 3, 4, 5, 6}).
        data.RemoveRange(countOfElementsToKeepAtStart, amount);

        // Step 4: Insert the copied elements (from Step 2) at the very beginning of the list.
        // The InsertRange() method does this efficiently.
        data.InsertRange(0, elementsToMove);

        // After this step, the original 'data' list has been successfully modified in place.
        // For example, it is now {7, 8, 9, 1, 2, 3, 4, 5, 6}.
        // Because the method is 'void', we don't need to return anything.
        /*var data = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int amount = 3;

        var result = new int[data.Length];
        int splitIndx = data.Length - amount; // This is the starting index of the part to be moved

        // 1. Copy the end part of data to the beginning of result var.
        for (int i = 0; i < amount; i++)
        {
            result[i] = data[splitIndx + i];
        }

        // 2. Copy the beginning part of 'data' to the end of result
        for (int i = 0; i < splitIndx; i++)
        {
            result[amount + i] = data[i];
        }*/

    }
}
