namespace Search_Insert_Position;

public static class SearchClass
{
    public static int Search(int[] nums, int target)
    {
        if(nums[0] == target)
        {
            return 0;
        }
        var left = 0;
        var right = nums.Length - 1;
        int mid = 0;

        if(nums[right] < target)
        {
            return right + 1;
        }
        
        while (left <= right)
        {
            mid = (right + left) / 2;
            if(nums[mid] == target)
            {
                return mid;
            }
            if (nums[mid] < target)
            {
                left = mid + 1;
            }

            if (nums[mid] > target)
            {
                right = mid - 1;
            }
        }
        return right + 1;
    }
}