public class Solution {
    public int Reverse(int x) {
        var negFlag = false;
        var rev = new string(x.ToString().Reverse().ToArray());
        if(rev[^1] == '-'){
            negFlag = true;
            rev = rev[0..^1];
        }
        try{
            return negFlag ? int.Parse("-"+ rev) : int.Parse(rev); 
        }
        catch{
            return 0;	
        }
    }
}