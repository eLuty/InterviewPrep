// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, 
// it reads the same forward and backward. Alphanumeric characters include letters and numbers.

// Given a string s, return true if it is a palindrome, or false otherwise.

using System.Text.RegularExpressions; // Required to use the Regex

public class Solution {
    public bool IsPalindrome(string s) {

        // Manipulate the string to remove all non-alphanumeric characters and change everything to lower case
        s = Regex.Replace(s, @"[\p{P}\s`]", "");
        s = s.ToLower();

        int left = 0;
        int right = s.Length - 1;

        while(left <= right){
            if(s[left] != s[right]){
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}