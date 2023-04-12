// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { -1, -100, 3, 99 };
        int[] nums2 = { -1, -10 , 0, 3, 11, 43, 99 };
        int[] nums3 = { 0, 1, 2, 3, 4, 5, 6 };
        int k = 2;
        RotateArray.Rotate(nums, k);
        k = 3;
        RotateArray.Rotate2(nums3, k);

        foreach (var num in nums)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("..........................");
        foreach (var num in nums3)
        {
            Console.WriteLine(num);
        }
    }
}