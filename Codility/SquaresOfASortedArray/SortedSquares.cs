namespace SquaresOfASortedArray;

public static class SortedSquares
{
    public static int[] SortedSquaresMethod1(int[] nums) 
    {
        var result = new int[nums.Length];
        var left = 0;
        var right = nums.Length - 1;
        
        if(nums[0] >= 0)
        {
            var index = 0;

            foreach(int num in nums)
            {
                nums[index] =  num * num;
                index++;
            }
        }
        
        if(nums[nums.Length - 1] < 0)
        {
            var res = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                res[nums.Length - (i+1)] = nums[i] * nums[i];
            }
            return res;
        }

        for(int i = nums.Length-1; i >= 0; i--)
        {
            if(Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                result[i] = nums[left] * nums[left];
                left++;
            }
            else
            {
                result[i] = nums[right] * nums[right];
                right--;
            }   
        }
        
        return result;
    }

    public static int[] SortedSquaresMethod2(int[] nums)
    {
        int[] numsSquare = new int[nums.Length];
        var index = 0;
        
        foreach(int num in nums)
        {
            numsSquare[index] =  num * num;
            index++;
        }
        
        Array.Sort(numsSquare);
        
        return numsSquare;
    }
}