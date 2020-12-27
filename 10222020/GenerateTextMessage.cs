public class Solution
{
	public IList<string> LetterCombinations(string digits)
	{
		var lookup = new Dictionary<int, string>(){ // phone number *digit* to *letter* mapping
			{2, "abc"},
			{3, "def"},
			{4, "ghi"},
			{5, "jkl"},
			{6, "mno"},
			{7, "pqrs"},
			{8, "tuv"},
			{9, "wxyz"}
		};
		var res = new List<string>(); // Output variable
		if (string.IsNullOrEmpty(digits)) return res; // Null check
		var queue = new Queue<(string, string)>(); // for processing
		queue.Enqueue(("", digits)); // seed data
		while (queue.Count != 0)
		{
			(string combo, string digits) curr = queue.Dequeue();
			foreach (var i in lookup[int.Parse(curr.digits[0].ToString())]) // For each letter in mapping
			{
				var updatedCombo = curr.combo + i;
				var updatedDigits = curr.digits.Substring(1);
				if (updatedDigits.Length != 0) queue.Enqueue((updatedCombo, updatedDigits)); // add back to queue if further digits remain
				else res.Add(updatedCombo); // else end processing and add to result
			}
		}
		return res;
	}
}