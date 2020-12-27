public class Solution {
    public Boolean SelfDivideHelper(int s){
            var digitSet = s.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToHashSet();
            if(digitSet.Contains(0)){
                return false;
            }
            foreach(var i in digitSet){
                if(s%i != 0){
                    return false;
                }
            }
            return true;
        }

        public IList<int> SelfDividingNumbers(int left, int right) {
            // Iterate over and filter
            return Enumerable.Range(left,(right-left+1)).Where(x => SelfDivideHelper(x)).ToList();
        }
}