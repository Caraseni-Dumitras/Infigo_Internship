namespace FirstBadVersion;

public class VersionControl
{
    public bool IsBadVersion(int n)
    {
        int[] badVersions = { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        int myIndex = Array.BinarySearch(badVersions, n);
        if (myIndex >= 0)
        {
            return true;
        }

        return false;
    }
}