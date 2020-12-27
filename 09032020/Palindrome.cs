using System;

public class Palindrome{
    // Problem: routine palindrome question ignoring for case and punctuation
    // "level", return true
    //Console.WriteLine(IsPalindrome("level"));
    // "algorithm", return false
    //Console.WriteLine(IsPalindrome("algorithm"));
    // "A man, a plan, a canal: Panama.", return true
    //Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama."));

    public bool IsPalindrome(string s){
        s=s.ToLower();
        int lo = 0, hi = s.Length-1;
        while(lo<=hi){
            if((int)s[lo]< 97 || (int)s[lo]> 122){
                lo+=1;
            }
            else if ((int)s[hi] < 97 || (int)s[hi] > 122){
                hi-=1;
            }
            else{
                if(s[lo] != s[hi]){
                    return false;
                }
                lo += 1;
                hi -= 1;
            }
        }
        return true;
    }
}