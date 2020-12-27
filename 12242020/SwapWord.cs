public class Solution {
    public string ReverseWords(string s)
    { 
        var words = s.Split(" ").Where(x => !string.IsNullOrEmpty(x));
        return string.Join(" ", words.Reverse().Select(x => x.Trim()));
    }
}