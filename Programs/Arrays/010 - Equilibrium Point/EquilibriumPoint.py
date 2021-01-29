def equilibrium(arr):
    total_sum = sum(arr)
    leftsum = 0
    for i, num in enumerate(arr):
        total_sum -= num

        if leftsum == total_sum:
            return i + 1
        leftsum += num

    return -1


# Driver code
arr = [1,3,5,2,2]
print('First equilibrium index is ', equilibrium(arr))
