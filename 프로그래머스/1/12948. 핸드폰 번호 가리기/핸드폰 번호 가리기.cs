public class Solution {
    public string solution(string phone_number) {
        
        char[] chars = phone_number.ToCharArray();
        for(int i = 0; i < phone_number.Length - 4; i++)
        {
            chars[i] = '*';
        }
        string answer = new string(chars);
        return answer;
    }
}