// Given an array of integers nums which is sorted in ascending order, and an integer target,
// write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.
//
// You must write an algorithm with O(log n) runtime complexity.
//
// Example 1:
//
// Input: nums = [-1,0,3,5,9,12], target = 9
// Output: 4
// Explanation: 9 exists in nums and its index is 4
// Example 2:
//
// Input: nums = [-1,0,3,5,9,12], target = 2
// Output: -1
// Explanation: 2 does not exist in nums so return -1

using Binary_Search;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {-1,0,3,5,6,9,12}; 
        int target = 7;
        var result = Search1.SearchMethod(nums, target); 
        var result2 = Search2.SearchMethod2(nums, target);
        var result3 = Search3.SearchMethod3(nums, target);
        Console.WriteLine($"The result of SearchMethod1: {result}"); 
        Console.WriteLine($"The result of SearchMethod2: {result2}");
        Console.WriteLine($"The result of SearchMethod3: {result3}");
    }
}
 