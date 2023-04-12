

public static class RotateArray
{
    public static void Rotate(int[] nums, int k) {
        int i = 0;
        var left = 0;
        var right = nums.Length - 1;

        k = k % nums.Length;

        if (k == 0)
        {
            return;
        }
        
        if (nums.Length < 2)
        {
            return;
        }
        
        while(i < k)
        {
            int insert = nums[0];
            while (left < right)
            {
                int temp = nums[left+1];
                nums[left+1] = insert;
                insert = temp;
                left++;
                if(left == right)
                {
                    nums[0] = insert;
                }
            }
            left = 0;
            right = nums.Length - 1;
            i++;
        }
    }

    public static void Rotate2(int[] nums, int k)
    {
        if (nums.Length < 2)
        {
            return;
        }
        
        k = k % nums.Length;
        
        int[] temp = new int[k];
        
        if(k == 0)
        {
            return;
        }
        
        for (int i = 0; i < k; i++)
        {
            temp[i] = nums[i+nums.Length - k];
        }        
        
        for (int i = nums.Length - k - 1; 0 <= i; i--)
        {
            int insert = i + k;
            int tempNumber = nums[i];
            nums[i] = nums[insert];
            nums[insert] = tempNumber;
        }
        
        for (int i = 0; i < k; i++)
        {
            nums[i] = temp[i];
        }
    }
}