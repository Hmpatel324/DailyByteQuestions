bool Anagram(string s, string t){
	// Pool Create
	var letterPool = t.ToCharArray()
				  .GroupBy(x => x)
				  .ToDictionary(x => x.Key, x=> x.Count());
	foreach(var i in s){
		if(!letterPool.ContainsKey(i)){
			return false;
		}
		letterPool[i]-=1;
		if(letterPool[i]==0) letterPool.Remove(i);
	}
	return true;
}




// This question is asked by Facebook. Given two strings s and t return whether or not s is an anagram of t. 
// Note: An anagram is a word formed by reordering the letters of another word. 
// 
// Ex: Given the following strings...
// s = "cat", t = "tac", return true
//Console.WriteLine(Anagram("cat", "tac"));
// s = "listen", t = "silent", return true
//Console.WriteLine(Anagram("listen", "silent"));
// s = "program", t = "function", return false
//Console.WriteLine(Anagram("function", "program"));