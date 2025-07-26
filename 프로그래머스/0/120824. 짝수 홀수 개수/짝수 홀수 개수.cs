using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int x = 0;
        int y = 0;
        foreach(int n in num_list)
        {
            if (n % 2 == 0) x++;
            else y++;
        }
        int[] answer = new int[] {x, y};
        return answer;
    }
}