/*
Dictionary<TKey, TValue> (Equivalent of HashMap)
A Dictionary in C# is essentially a hash table-based data structure that allows you to store key-value pairs for fast lookup.

Features of Dictionary (HashMap in C#)
Uses a hashing algorithm for fast lookup and  Provides O(1) average time complexity for search, insert, and delete.
 
*/
//     public int[] TwoSum(int[] nums, int target) {
//         Dictionary<int,int> indexValDict = new Dictionary<int,int>(); 
//         for(int i = 0; i < nums.Length ; i++){
//             int val = nums[i];
//             int val2 = target - val;

//             if(indexValDict.ContainsValue(val2)){
//                 int val2Index = Array.FindIndex(nums,num=>num==val2);
//                 return [i, val2Index];
//             }
// ******Here I have stored index as the key and value as the value// but thhere is no method to retrieve key using O(n) time complexity 
//therefore below method is perfect
//             indexValDict.Add(i,val);
//         }
//         return new[]{};
//     }
/*
      Dictionary operations (indexValDict.ContainsValue(val2), indexValDict.Add(i, val)) are involved:

ContainsValue(val2) is an O(n) operation since it searches through all values in the dictionary.
Add(i, val) is an O(1) operation.
Finding an index with Array.FindIndex(nums, num => num == val2);:

This operation is O(n) in the worst case because it scans the entire array.
Thus, the worst-case scenario results in O(n²) time complexity due to the ContainsValue check and FindIndex.
  
*/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> indexValDict = new Dictionary<int, int>(); 

        for (int i = 0; i < nums.Length; i++) {
            int val = nums[i];
            int val2 = target - val;

            if (indexValDict.ContainsKey(val2)) {
                return new int[] { indexValDict[val2], i };
            }

            // ******Store the value as the key and index as the value
            indexValDict[val] = i;
        }

        return new int[] {}; // Return empty if no solution is found
    }
}
