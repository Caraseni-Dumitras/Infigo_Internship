// Given a sorted array of distinct integers and a target value, return the index if the target is found.
// If not, return the index where it would be if it were inserted in order.
//
// You must write an algorithm with O(log n) runtime complexity.
//
// Example 1:
//
// Input: nums = [1,3,5,6], target = 5
// Output: 2
// Example 2:
//
// Input: nums = [1,3,5,6], target = 2
// Output: 1
// Example 3:
//
// Input: nums = [1,3,5,6], target = 7
// Output: 4

using Search_Insert_Position;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 15, 16};
        int[] nums2 = { 1, 3, 5 ,6 };
        var target = 17;
        var index = SearchClass.Search(nums, target);
        Console.WriteLine($"The number {target} should be on position {index}");
    }
}