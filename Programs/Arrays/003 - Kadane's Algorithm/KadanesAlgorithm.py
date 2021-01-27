def maxSubArraySum(arr):
    size = len(arr)
    max_so_far = arr[0]
    curr_max = arr[0]

    for i in range(size):
        curr_max = max(arr[i], curr_max + arr[i])
        max_so_far = max(max_so_far, curr_max)

    return max_so_far


# Driver function to check the above function
a = [-2, -3, 4, -1, -2, 1, 5, -3]
print("Maximum contiguous sum : ", maxSubArraySum(a))
