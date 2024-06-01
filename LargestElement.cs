using System;

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        return Quickselect(nums, 0, nums.Length - 1, nums.Length - k);
    }

    private int Quickselect(int[] nums, int left, int right, int k_smallest) {
        if (left == right) {
            return nums[left];
        }
        
        Random random = new Random();
        int pivot_index = left + random.Next(right - left + 1);

        pivot_index = Partition(nums, left, right, pivot_index);

        if (k_smallest == pivot_index) {
            return nums[k_smallest];
        } else if (k_smallest < pivot_index) {
            return Quickselect(nums, left, pivot_index - 1, k_smallest);
        } else {
            return Quickselect(nums, pivot_index + 1, right, k_smallest);
        }
    }

    private int Partition(int[] nums, int left, int right, int pivot_index) {
        int pivot = nums[pivot_index];
        // Move pivot to end
        Swap(nums, pivot_index, right);
        int store_index = left;

        for (int i = left; i < right; i++) {
            if (nums[i] < pivot) {
                Swap(nums, store_index, i);
                store_index++;
            }
        }
        // Move pivot to its final place
        Swap(nums, right, store_index);

        return store_index;
    }

    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
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
