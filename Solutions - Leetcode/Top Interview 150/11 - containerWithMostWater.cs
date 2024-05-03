// You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of 
// the ith line are (i, 0) and (i, height[i]).

// Find two lines that together with the x-axis form a container, such that the container contains the most water.

// Return the maximum amount of water a container can store.

public class Solution {
    public int MaxArea(int[] height) {
        // set max area
        int maxArea = 0;

        // set left and right pointers
        int l = 0;
        int r = height.Length - 1;

        while(l < r){
            // calc the area between the 2 pointers. take the smallest height for the y axis
            int area = (r - l) * (height[l] > height[r] ? height[r] : height[l]);
            
            if(area > maxArea)
                // if new area is larger, it becomes our new max
                maxArea = area;
            else{
                // area is not larger, move the pointer with the smallest height
                if(height[l] < height[r])
                    l++;
                else
                    r--;
            }
        }

        return maxArea;
    }
}