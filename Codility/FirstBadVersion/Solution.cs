namespace FirstBadVersion;

public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int left = 0;

        if(n == 1 && IsBadVersion(n))
        {
            return n;
        }

        while(left <= n)
        {
            if(left == n)
            {
                break;
            }
            var mid = left + (n-left) / 2;
            if(IsBadVersion(mid))
            {
                n = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }
}