public class Solution {
    public bool IsPalindrome(int x) {
        String s = x.ToString();
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        String s2 = new String(charArray);
            if(s == (s2))
                return true;
            else
                return false;
    }
}