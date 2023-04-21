

public static class TwoSum
{
    public static int[] TwoSumMethod(int[] numbers, int target)
    {
        if (numbers.Length > 2) 
        {
            var prev = new Dictionary<int, int>();
            for (var i = 0; i < numbers.Length; i++) 
            {
                if (prev.ContainsKey(target - numbers[i])) 
                {
                    return new[] {prev[target - numbers[i]] + 1, i + 1};
                }
                if (!prev.ContainsKey(numbers[i])) 
                {
                    prev.Add(numbers[i], i);
                }
            }
        }
        return new int[2]{1,2};
    }
}