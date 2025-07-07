using System;

public static class newArray
{

    public static void Run()
    {
        var line1 = new[] { 20, 40, 56, 89, 16, 21 };
        var line2 = new[] { 1, 2, 3, 4, 5, 6 };
        var order = new[] { 2, 1, 1, 1, 1, 2, 2, 1, 2, 1 };

        var intDisplay = ListOrder(line1, line2, order);
        Console.WriteLine("int[]>{" + string.Join(", ", intDisplay) + "}");
    }

    public static int[] ListOrder(int[] l1, int[] l2, int[] order)
    {
        var result = new int[order.Length];
        var l1x = 0;
        var l2x = 0;
        for (var i = 0; i < order.Length; i++)
        {
            if (order[i] == 1)
                result[i] = l1[l1x++];
            else
                result[i] = l2[l2x++];
        }

        return result;
    }
}