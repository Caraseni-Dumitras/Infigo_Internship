namespace ReverseWordsInAStringIII;

public class ReverseWords
{
    public static string ReverseWordsMethod(string s) {
        if(s.Length == 1)
        {
            return s;
        }
        
        var stringToArray = s.ToArray(); 
        var l = 0;
        var r = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (stringToArray[i] == ' ' || i + 1 >= s.Length) 
            {
                if (i + 1 >= s.Length)
                {
                    r = i;
                }
                else
                {
                    r = i - 1;
                }

                while (l < r)
                {
                    var temp = stringToArray[l];
                    stringToArray[l] = stringToArray[r];
                    stringToArray[r] = temp;
                    l++;
                    r--;
                }
                l = i + 1;
            }
        }

        return new string(stringToArray);
    }
}