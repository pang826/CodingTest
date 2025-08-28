using System;
using System.Text;
using System.Collections.Generic;
public class Solution {
    public string solution(int[] food) {
        StringBuilder sb = new StringBuilder();
        Stack<int> s = new Stack<int>();
        List<int> list = new List<int>();
        for(int i = 1; i < food.Length; i++)
        {
            if(food[i] / 2 < 1) 
            {
                list.Add(0);
                continue;
            }
            
            list.Add(food[i] / 2);
        }
        
        for(int j = 0; j < list.Count; j++)
        {
            if(list[j] == 0) continue;
            for(int k = 0; k < list[j]; k++)
            {
                sb.Append(j + 1);
                s.Push(j + 1);
            }
        }
        sb.Append('0');
        
        while(s.Count > 0) 
            sb.Append(s.Pop());
        
        return sb.ToString();
    }
}