// Given an integer array nums sorted in non-decreasing order, return an array of the squares
// of each number sorted in non-decreasing order.
//
// Example 1:
//
// Input: nums = [-4,-1,0,3,10]
// Output: [0,1,9,16,100]
// Explanation: After squaring, the array becomes [16,1,0,9,100].
//     After sorting, it becomes [0,1,9,16,100].

// Example 2:
//
// Input: nums = [-7,-3,2,3,11]
// Output: [4,9,9,49,121]

using SquaresOfASortedArray;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { -10, -3, 0, 1, 2, 3, 9 };
        int[] nums2 = { 1, 2, 3, 4, 10, 45, 100 };
        int[] nums3 = { -5, -4, -3, -2 };
        
        var result = SortedSquares.SortedSquaresMethod1(nums3);
        foreach (var num in result)
        {
            Console.WriteLine(num);
        }

        result = SortedSquares.SortedSquaresMethod2(nums2);
        Console.WriteLine("............................");
        foreach (var num in result)
        {
            Console.WriteLine(num);
        }
    }
}