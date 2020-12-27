bool CapitalizationCheck(string s){
	bool flagAllCaps = true, camelCaseFlag = true, lowerCaseFlag = true;
	int index = 0;
	foreach(var asciiLetter in s.Select(x => (int)x)){
		if(index!=0 && asciiLetter>=65 && asciiLetter<=90){
			camelCaseFlag = false;
			lowerCaseFlag = false;
		}
		if(asciiLetter >= 97 && asciiLetter <= 122){
			flagAllCaps = false;
		}
		index+=1;
	}
	return (flagAllCaps || camelCaseFlag || lowerCaseFlag);
}

//string input;
//input = "USA";
//Console.WriteLine(CapitalizationCheck(input));
//input = "Calvin";
//Console.WriteLine(CapitalizationCheck(input));
//input = "compUte";
//Console.WriteLine(CapitalizationCheck(input));
//input = "coding";
//Console.WriteLine(CapitalizationCheck(input));

//
//This question is asked by Google.
//Given a string, return whether or not it uses capitalization correctly.
//A string correctly uses capitalization 


//if all letters are capitalized, 
//no letters are capitalized, or 
//only the first letter is capitalized.



//Ex: Given the following strings...
//"USA", return true
//"Calvin", return true
//"compUter", return false
//"coding", return true
//