using System;

public class today{
    public string ReverseString(string s){
        var sChar = s.ToCharArray();
        int lo = 0, hi = s.Length-1;
        while(lo<=hi){
            var temp = sChar[lo];
            sChar[lo] = sChar[hi];
            sChar[hi] = temp;
            lo+=1;
            hi-=1;
        }
        return new string(sChar);
    }

// // Prompt: implement a string reverse method that returns a string in reverse order. 
// //		Word Order should ALSO be reversed

// //“Cat”, return “taC”
// Console.WriteLine(ReverseString("Cat"));
// // “The Daily Byte”, return "etyB yliaD ehT”
// Console.WriteLine(ReverseString("The Daily Byte"));
// // “civic”, return “civic”
// Console.WriteLine(ReverseString("civic"));
}