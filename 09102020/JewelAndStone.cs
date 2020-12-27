int JewelAndStone(string jewels, string stones){
	var res = 0;
	var jewelSet = jewels.ToCharArray().ToHashSet();
	foreach(var i in stones){
		if(jewelSet.Contains(i)) res+=1;
	}
	return res;
}



// This question is asked by Amazon. Given a string representing your stones and another string representing a list of jewels, return the number of stones that you have that are also jewels. 
// 
// Ex: Given the following jewels and stones...
// jewels = "abc", stones = "ac", return 2
// Console.WriteLine(JewelAndStone("abc", "ac"));
// jewels = "Af", stones = "AaaddfFf", return 3
// Console.WriteLine(JewelAndStone("Af", "AaaddfFf"));
// jewels = "AYOPD", stones = "ayopd", return 0
// Console.WriteLine(JewelAndStone("AYOPD", "ayopd"));