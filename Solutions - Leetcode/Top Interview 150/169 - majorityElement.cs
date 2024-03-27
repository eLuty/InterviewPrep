public class Solution {
    public int MajorityElement(int[] nums) {

        int majorityElement = nums[0];
        int maxCount = 0;
        Dictionary<int, int> elementCounts = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            if(elementCounts.ContainsKey(nums[i])){
                elementCounts[nums[i]] = elementCounts[nums[i]]++;
            }
            else{
                elementCounts.Add(nums[i], 1);
            }
        }

        foreach(int element in elementCounts){
            if(element.Value > maxCount){
                majorityElement = element.Key;
                maxValue = element.Value;
            }
        }

        return majorityElement;
    }
}