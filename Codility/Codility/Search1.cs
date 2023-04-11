namespace Codility;

public static class Search1
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
}