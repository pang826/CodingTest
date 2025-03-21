using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        int[] answer;
        if(arr.Length == 1)
        {
            answer = new int[]{-1};
            return answer;
        }
        else
        {
            List<int> list = new List<int>(arr);
            int num = arr.Min();
            
            list.Remove(num);
            
            return list.ToArray();
        }
    }
}