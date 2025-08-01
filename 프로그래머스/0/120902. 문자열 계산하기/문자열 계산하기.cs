using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string[] a = my_string.Split(' ');
        List<int> list = new List<int>();
        List<string> sList = new List<string>();
        for(int i = 0; i < a.Length; i++)
        {
            if(int.TryParse(a[i], out int j))
                list.Add(j);
            else
                sList.Add(a[i]);
        }
        for(int j = 0; j < list.Count; j++)
        {
            if(j == 0)
            {
                answer = list[j];
                continue;
            }
            if(sList[j - 1] == "+")
                answer += list[j];
            else
                answer -= list[j];
        }
        return answer;
    }
}