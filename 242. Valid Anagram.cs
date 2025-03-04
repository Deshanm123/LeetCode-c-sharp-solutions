

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        } 
        // 26 lowercase letters in the English alphabet a=0 z=25 
        //this solution is limit to only lower case letters
       int[] charCount =new int[26];

        
       for(int i = 0 ; i <s.Length; i++){
        //eg ->z-a = 25 th index (asci value) 
        //, inother words if z is present 25 iindex will be         increased by 1
         charCount[s[i]-'a']++;
         charCount[t[i]-'a']--;
       }

        foreach(var x in charCount){
            if(x != 0)
             return false;
        }
        return true;
    }
}
