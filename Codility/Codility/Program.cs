using Codility;

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
 