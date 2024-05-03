// Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they 
// add up to a specific target number. Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.

// Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.

// The tests are generated such that there is exactly one solution. You may not use the same element twice.

// Your solution must use only constant extra space.

public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        // Init 2 pointers
        int l = 0;
        int r = numbers.Length - 1;

        // If L or R pass each other, there is no possible combination.
        while(l < r){
            int sum = numbers[l] + numbers[r];
            if(sum > target){
                // if the sum is too big, move the right pointer
                r--;
            }
            else if(sum < target){
                // if the sum is too small, move the left pointer
                l++;
            }
            else{
                // combo found, add 1 to each index
                return [l + 1, r + 1];
            }
        }

        return [];
    }
}