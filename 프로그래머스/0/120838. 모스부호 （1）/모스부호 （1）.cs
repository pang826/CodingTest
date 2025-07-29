using System;
using System.Text;
using System.Collections.Generic;
public class Solution {
    public string solution(string letter) {
        string[] mos = new string[]{".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        string[] answers = letter.Split(" ");
        Dictionary<string, char> strDic = new Dictionary<string, char>();
        // 97 ~ 122
        for(int i = 0; i < mos.Length; i++)
        {
            strDic.Add(mos[i], (char)(i+97));
        }
        
        StringBuilder sb = new StringBuilder();
        for(int j = 0; j < answers.Length; j++)
        {
            if(strDic.TryGetValue(answers[j], out char c))
            {
                sb.Append(c);
            }
        }
        
        return sb.ToString();
    }
}