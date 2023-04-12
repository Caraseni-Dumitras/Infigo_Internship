namespace Binary_Search;

public static class Search
{
    public static int SearchMethod(int[] nums, int target) 
    {
        int index = 0;

        foreach(int n in nums)
        {
            if(n == target)
            {
                return index;
            }
            index++;
        }

        index = -1;
        return index;
    }
    
    public static int SearchMethod2(int[] nums, int target)
    {
        int myIndex = Array.BinarySearch(nums, target);
        if (myIndex < 0)
        {
            myIndex = -1;
        }
        return myIndex;
    }
    public static int SearchMethod3(int[] nums, int target)
    {
        int index = -1;
        var min = 0;
        var max = nums.Length - 1;
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