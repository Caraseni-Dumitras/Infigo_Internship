namespace Binary_Search;

public static class Search2
{
    public static int SearchMethod2(int[] nums, int target)
    {
        int myIndex = Array.BinarySearch(nums, target);
        if (myIndex < 0)
        {
            myIndex = -1;
        }
        return myIndex;
    }
}