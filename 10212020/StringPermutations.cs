public class Solution
{
	public IList<string> LetterCasePermutation(string S)
	{
		var res = new List<string>();
		var queue = new Queue<(string, string)>();
		queue.Enqueue((string.Empty, S));
		while (queue.Count > 0)
		{
			(string permutation, string pool) curr = queue.Dequeue();
			if (string.IsNullOrEmpty(curr.pool)) res.Add(curr.permutation);
			else
			{
				var currChar = curr.pool[0];
				// char is a #
				if ((int)currChar >= 47 && (int)currChar <= 57) queue.Enqueue((curr.permutation + currChar, curr.pool[1..]));
                // char is a letter so need to enqueue lower and uppercase
				else
				{
					queue.Enqueue((curr.permutation + currChar.ToString().ToLower(), curr.pool[1..]));
					queue.Enqueue((curr.permutation + currChar.ToString().ToUpper(), curr.pool[1..]));
				}
			}
		}
		return res;
	}
}
