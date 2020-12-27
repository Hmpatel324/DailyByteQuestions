int FirstUniqueChar(string s){
	var uniqueSet = s.GroupBy(x => x)
						   .Where(x => x.Count() == 1)
						   .Select(x => x.Key)
						   .ToHashSet();
	int i = 0;
	while(i < s.Length){
		if(uniqueSet.Contains(s[i])) return i;
		i += 1;
	}
	return -1;
}




// This question is asked by Microsoft.
// Given a string, return the index of its first unique character.If a unique character does not exist, return -1. 


// Ex: Given the following strings...
// "abcabd", return 2
// Console.WriteLine(FirstUniqueChar("abcabd"));
// "thedailybyte", return 1
// Console.WriteLine(FirstUniqueChar("thedailybyte"));
// "developer", return 0
// Console.WriteLine(FirstUniqueChar("developer"));