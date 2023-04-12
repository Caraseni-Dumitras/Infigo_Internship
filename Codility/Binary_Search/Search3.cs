namespace Binary_Search;

public static class Search3
{
    public static int SearchMethod3(int[] nums, int target)
    {
        int index = -1;
        var min = 0;
        var max = nums.Length;
        var mid = max / 2;
        
        if(nums.Length == 0)
        {
            return index;
        }
        
        while(min < max)
        {

            if(target == nums[mid])
            {
                index = mid;
                break;
            }
            if(target > nums[mid])
            {
                min = mid + 1;
                mid = (min + max) / 2;
            }
            else
            {
                max = mid;
                mid = max / 2;
            }
        }
        return index;
    }
}