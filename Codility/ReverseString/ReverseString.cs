
public class ReverseString
{
    public static void ReverseStringMethod(char[] s)
    {
        if(s.Length == 1)
        {
            return;
        }
        for(int i = 0; i < s.Length / 2; i++)
        {
            var temp = s[i];
            s[i] = s[s.Length - i - 1];
            s[s.Length - i - 1] = temp;
        }
    }
}