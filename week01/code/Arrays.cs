public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Initialize array "multiples" for holding the multiples of "number" and "lenght"
        double[] multiples = new double[length];

        // Step 2: Generate multiples with a for loop, starting with 0 and adding 1 until equal with "length"
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // Step 3: Return pipulated array of multiples
        return multiples;
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

        // Step 1: Use modulo to normalize the rotation amount
        int count = data.Count;
        amount = amount % count;

        // Step 2: Identify exact split point and slice to extract two parts
        List<int> part1 = data.GetRange(count - amount, amount); // Last 'amount' elements from end of list
        List<int> part2 = data.GetRange(0, count - amount);       // First 'count - amount' elements of list

        // Step 3: Clear original list and combine the parts to one list
        data.Clear();
        data.AddRange(part1); // Add the rotated part first
        data.AddRange(part2); // Add the remaining elements
    }
}
