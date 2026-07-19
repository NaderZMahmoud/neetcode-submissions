public class Solution {
    public bool IsPalindrome(string s) {
        
        string tempStr= string.Empty;
        StringBuilder strBuilder = new StringBuilder();
        for(int i=0; i< s.Length; i++)
        {
            if(Char.IsLetterOrDigit(s[i]))
            {
                strBuilder.Append(Char.ToLower(s[i]));
            }
        }
        tempStr= strBuilder.ToString();
        if(tempStr.Length == 0)
        {
            return true;
        }
        int start = 0;
        int end=tempStr.Length-1;

        while(start< end)
        {
            if(tempStr[start] != tempStr[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}
