// Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

// A subsequence of a string is a new string that is formed from the original string by 
// deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. 
// (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

public class Solution {
    public bool IsSubsequence(string s, string t) {
        int left = 0;
        int right = 0;

        while(left < s.Length && right < t.Length){
            if(s[left] == t[right])
                left++;

            right++; // right pointer is incremented no matter the outcome
        }

        if(left == s.Length)
            return true; // if you reach the end of s, all letters were found in t
        else
            return false;
    }
}