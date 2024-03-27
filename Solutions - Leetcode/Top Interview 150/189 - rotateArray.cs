// Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.
public class Solution {
    public void Rotate(int[] nums, int k) {

        // O(n) time and space
        
        int[] tempArray = new int[nums.Length];

        for(int i = 0; i < nums.Length; i++){
            int newIndex = (i + k) % nums.Length;
            tempArray[newIndex] = nums[i];
        }

        tempArray.CopyTo(nums, 0);
    }
}