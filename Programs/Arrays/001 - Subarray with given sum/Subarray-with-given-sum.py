def subArraySum(arr, sum_result):
    n = len(arr)
    curr_sum = arr[0]
    start = 0
    i = 1

    while i <= n:
        while curr_sum > sum_result and start < i - 1:
            curr_sum = curr_sum - arr[start]
            start += 1

        if curr_sum == sum_result:
            print("Sum found between indexes %d and %d" % (start, i - 1))
            return 1

        if i < n:
            curr_sum = curr_sum + arr[i]
        i += 1

    print("No subarray found")
    return 0


# Driver program
arr = [15, 2, 4, 8, 9, 5, 10, 23]
result = 23

subArraySum(arr, result)
