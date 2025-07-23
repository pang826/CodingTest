public class Solution {
    public bool solution(string s) {
        bool checkOnlyNum = true;
        bool checkLength = false;
        char[] c = s.ToCharArray();
        
        if(c.Length == 4 || c.Length == 6)
            checkLength = true;
        //48 57
        foreach(char i in c)
        {
            if(i > 57 || i < 48)
                checkOnlyNum = false;
        }
        
        if(checkLength && checkOnlyNum)
            return true;
        else
            return false;
    }
}