

public static class MoveZeroes
{
    public static void MoveZeroesMethod(int[] nums)
    {
        if(nums.Length < 2)
        {
            return;
        }
        
        int j = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                var temp = nums[j];
                nums[j] = nums[i];
                nums[i] = temp;
                j++;
            }
        }
    }
}