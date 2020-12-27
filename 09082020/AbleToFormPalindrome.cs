bool FormPalindrome(string s){
	int lo = 0, hi = s.Length-1, muligan = 1;
	while(lo <= hi){
		if(s[lo] != s[hi]){
			if(muligan == 0){
				return false;
			}
			muligan -= 1;
		}
		lo+=1;
		hi-=1;
	}
	return true;
}

//This question is asked by Facebook.Given a string and the ability to delete at most one character, return whether or not it can form a palindrome.
//Note: a palindrome is a sequence of characters that reads the same forwards and backwards.
//
//Ex: Given the following strings...
//
//"abcba", return true
//Console.WriteLine(FormPalindrome("abcba"));
//"foobof", return true(remove the first 'o', the second 'o', or 'b')
//Console.WriteLine(FormPalindrome("foobof"));
//"abccab", return false
//Console.WriteLine(FormPalindrome("abccab"));