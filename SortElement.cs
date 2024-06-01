using System;

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        // Sort the array in descending order
        Array.Sort(nums);
        Array.Reverse(nums);
        
        // The kth largest element will be at index k-1
        return nums[k - 1];
    }
}

public class Program {
    public static void Main() {
        Solution solution = new Solution();
        
        int[] nums1 = {3, 2, 1, 5, 6, 4};
        int k1 = 2;
        Console.WriteLine(solution.FindKthLargest(nums1, k1)); // Output: 5

        int[] nums2 = {3, 2, 3, 1, 2, 4, 5, 5, 6};
        int k2 = 4;
        Console.WriteLine(solution.FindKthLargest(nums2, k2)); // Output: 4
    }
}
