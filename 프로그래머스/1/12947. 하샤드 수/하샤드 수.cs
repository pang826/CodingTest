public class Solution {
    public bool solution(int x) {
        int num = x;
        int result = 0;
        while(x>0)
        {
            result += x % 10;
            x /= 10;
        }
    
        return num % result == 0;
    }
}