public class Solution {
    public string ReverseVowels(string s)
    {
        var sb = s.ToCharArray();
        int i = 0, j = s.Length-1;
        var vowels = new HashSet<char>(){'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
        while(i <= j ){
            if(!vowels.Contains(sb[i])) i+=1;
            else if(!(vowels.Contains(sb[j]))) j-=1;
            else{
                var temp = sb[i];
                sb[i] = sb[j];
                sb[j] = temp;
                i += 1;
                j -= 1;
            }
        }
        return string.Join("",sb);
    }
}