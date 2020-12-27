string[] NotCommonWords(string sentence1, string sentence2){
	HashSet<string> sent1Words = sentence1.Split(' ').ToHashSet(), sent2Words = sentence2.Split(' ').ToHashSet();
	sent1Words.SymmetricExceptWith(sent2Words);
	return sent1Words.ToArray();
}


// This question is asked by Amazon. Given two strings representing sentences, return the words that are not common to both strings 
// (i.e. the words that only appear in one of the sentences). You may assume that each sentence is a sequence of words (without punctuation) correctly separated using space characters. 
//
// Ex: given the following strings...
// sentence1 = "the quick", sentence2 = "brown fox", return ["the", "quick", "brown", "fox"]
//var sentence1 = "the quick";
//var sentence2 = "brown fox";
//Console.WriteLine(NotCommonWords(sentence1, sentence2));
// sentence1 = "the tortoise beat the haire", sentence2 = "the tortoise lost to the haire", return ["beat", "to", "lost"]
//sentence1 = "the tortoise beat the haire";
//sentence2 = "the tortoise lost to the haire";
//Console.WriteLine(NotCommonWords(sentence1, sentence2));
// sentence1 = "copper coffee pot", sentence2 = "hot coffee pot", return ["copper", "hot"]
//sentence1 = "copper coffee pot";
//sentence2 = "hot coffee pot";
//Console.WriteLine(NotCommonWords(sentence1, sentence2));