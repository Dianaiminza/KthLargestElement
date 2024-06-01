# FindKthLargest Method:

- This method initiates the Quickselect algorithm to find the kth largest element.
- The kth largest element is the same as the (len(nums) - k)th smallest element, hence nums.Length - k is passed.

# Quickselect Method:

- This recursive method partitions the array and selects a pivot element.
- Depending on the position of the pivot, it either finds the kth smallest element directly or recurses into the appropriate subarray.

# Partition Method:

- This method partitions the array around a pivot and places the pivot in its correct sorted position.
- Elements less than the pivot are moved to the left and elements greater than the pivot to the right.

# Swap Method:

- A helper method to swap elements in the array.
# Program Class with Main Method:

- Demonstrates how to use the Solution class to find the kth largest element with example inputs.
