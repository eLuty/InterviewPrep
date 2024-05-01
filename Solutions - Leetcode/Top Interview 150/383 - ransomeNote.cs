// Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

// Each letter in magazine can only be used once in ransomNote.

public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary <char, int> magazineMap = new Dictionary<char, int>();

        foreach(char letter in magazine){
            if(!magazineMap.ContainsKey(letter)){
                magazineMap.Add(letter, 1);
            }
            else{
                magazineMap[letter]++;
            }
        }

        foreach(char ransomLetter in ransomNote){
            if(magazineMap.ContainsKey(ransomLetter) && magazineMap[ransomLetter] > 0){
                magazineMap[ransomLetter]--;
            }
            else{
                canConstruct = false;
                return false;
            }
        }

        return true;
    }
}