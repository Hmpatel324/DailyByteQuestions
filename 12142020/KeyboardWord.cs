public class Solution {
    public bool FindWordHelper(HashSet<char> letterCache, char[] word){
        foreach(var i in word){
            if(!letterCache.Contains(i)) return false;
        }
        return true;
    }
    
    public string[] FindWords(string[] words)
    {
        var top = new HashSet<char>() { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p' };
        var middle = new HashSet<char> { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l'};
        var bottom = new HashSet<char> { 'z', 'x', 'c', 'v', 'b', 'n', 'm'};

        var res = new List<string>();
        foreach(var i in words){
            var toAdd = false;
            var iToLower = i.ToLower();
            if (top.Contains(iToLower[0])) toAdd = FindWordHelper(top, iToLower.ToCharArray()[1..]);
            else if (middle.Contains(iToLower[0])) toAdd = FindWordHelper(middle, iToLower.ToCharArray()[1..]);
            else if (bottom.Contains(iToLower[0])) toAdd = FindWordHelper(bottom, iToLower.ToCharArray()[1..]);
            if(toAdd) res.Add(i);
        }
        return res.ToArray();
    }
}