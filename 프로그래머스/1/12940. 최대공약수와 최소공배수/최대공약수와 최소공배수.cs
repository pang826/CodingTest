public class Solution {
    public int[] solution(int n, int m) {
        int a = n;
        int b = m;
        
        int x = 0;
        int y = 0;
        
        while(b != 0 && b >= 0)
        {
            int k = a;
            a = b;
            b = k % b;
        }
        x = a;
        y = (n * m) / x;
        
        int[] answer = new int[] { x, y };
        return answer;
    }
}