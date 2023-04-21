// Given a string s, reverse the order of characters in each word within a
// sentence while still preserving whitespace and initial word order.
//
// Example 1:
//
// Input: s = "Let's take LeetCode contest"
// Output: "s'teL ekat edoCteeL tsetnoc"
// Example 2:
//
// Input: s = "God Ding"
// Output: "doG gniD"


using ReverseWordsInAStringIII;

internal class Program
{
    public static void Main(string[] args)
    {
        var s = "Let's take Leet Code contest!";
        Console.WriteLine(ReverseWords.ReverseWordsMethod(s));
    }
}