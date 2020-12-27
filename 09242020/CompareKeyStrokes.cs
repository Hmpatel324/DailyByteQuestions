bool CompareKeystrokes(string s, string t){
	var sStack = new Stack<char>();
	var tStack = new Stack<char>();
	foreach(var i in s){
		if(i=='#') sStack.Pop();
		else sStack.Push(i);
	}
	foreach (var i in t)
	{
		if (i == '#') tStack.Pop();
		else tStack.Push(i);
	}
	while(tStack.Count > 0 && sStack.Count > 0){
		var currS = sStack.Pop();
		var currT = tStack.Pop();
		if(currS != currT) return false;
	}
	return (tStack.Count == 0 && sStack.Count == 0) ? true : false;
}


// This question is asked by Amazon. Given two strings s and t, which represents a sequence of keystrokes, 
// where # denotes a backspace, return whether or not the sequences produce the same result. 

// Ex: Given the following strings...
// s = "ABC#", t = "CD##AB", return true
// Console.WriteLine(CompareKeystrokes("ABC#","CD##AB"));
// s = "como#pur#ter", t = "computer", return true
// Console.WriteLine(CompareKeystrokes("como#pur#ter","computer"));
// s = "cof#dim#ng", t = "code", return false
// Console.WriteLine(CompareKeystrokes("cof#dim#ng","computer"));