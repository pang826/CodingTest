using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int n) 
    {
        List<int> answer = new List<int>(){};
        int odd = 0;

        for(int i = 0; i < n; i++)
        {
            if(i*2+1 > n)
            {
                break;
            }
            answer.Add(i*2+1);
        }
        int[] result = answer.ToArray();
        return result;
    }
}