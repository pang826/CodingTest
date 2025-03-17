public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        int[] intArray = new int[n];
        for(int i = 0; i < n; i++)
        {
            intArray[i] = i+1;
        }
        
        foreach(int i in intArray)
        {
            if(n % i == 0)
            {
                answer += i;
            }
        }
        return answer;
    }
}