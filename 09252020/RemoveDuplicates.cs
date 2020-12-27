string RemoveAdjacentLetters(string s){
	var stack = new Stack<char>();
	foreach(var currLetter in s){
		if(stack.Count>0 && stack.Peek()==currLetter){
			stack.Pop();
		}
		else{
			stack.Push(currLetter);
		}
	}
	return string.Join("",stack.ToArray());
}

// string s;
// //s = "abccba", return ""
// s = "abccba";
// Console.WriteLine($"Output: {RemoveAdjacentLetters(s)}");

// //s = "foobar", return "fbar"
// s = "foobar";
// Console.WriteLine($"Output: {RemoveAdjacentLetters(s)}");

// //s = "abccbefggfe", return "a"
// s = "abccbefggfe";
// Console.WriteLine($"Output: {RemoveAdjacentLetters(s)}");


//This question is asked by Facebook.Given a string s containing only lowercase letters, continuously remove adjacent characters that are the same and return the result.
//
//Ex: Given the following strings...
//
//s = "abccba", return ""
//s = "foobar", return "fbar"
//s = "abccbefggfe", return "a"