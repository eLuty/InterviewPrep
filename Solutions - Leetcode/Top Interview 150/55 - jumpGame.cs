// You are given an integer array nums. You are initially positioned at the array's first index, 
// and each element in the array represents your maximum jump length at that position.

// Return true if you can reach the last index, or false otherwise.

public class Solution {
    public bool CanJump(int[] nums) {
        // Goal is the last index
        int goal = nums.Length - 1;

        // Go through the array in reverse order
        for(int i = goal - 1; i >= 0; i--){

            // Does the previous element jump to the last index?
            int jumpDistance = i + nums[i];
            if(jumpDistance >= goal){

                // It does! Move the goalpost up                
                goal = i;
            }  
        }

        // If goal is equal to 0, jumps can be made to the last index.
        if(goal == 0)
            return true;
        else
            return false;

    }
}     
