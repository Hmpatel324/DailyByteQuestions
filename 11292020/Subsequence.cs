public class Solution {
    public bool IsSubsequence(string s, string t) {
        // Null Check
        if(string.IsNullOrEmpty(s)) return true;
        int subIndex = 0, sequenceIndex = 0;
        while(sequenceIndex < t.Length){
            // if pointer characters match
            if(s[subIndex] == t[sequenceIndex]){
                subIndex+=1;
                // Return true if all characters in the sub match
                if(subIndex==s.Length) return true;
            }
            sequenceIndex += 1;
        }
        return false;
    }
}