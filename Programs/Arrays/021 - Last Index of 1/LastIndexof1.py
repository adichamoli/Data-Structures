def FindIndex(arr, idx, k):
    if idx < 0:
        return -1;

    if arr[idx] == k:
        return idx

    return FindIndex(arr, idx - 1, k);


# Driver program
arr = [4, 3, 7, 8, 6, 2, 1]
n = len(arr)
result = FindIndex(arr, n - 1, 1)
print("Last Index of 1 : ", result)
