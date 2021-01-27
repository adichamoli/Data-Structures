def CountTriplets(arr, n):
    freq = [0 for i in range(100)]

    for i in range(n):
        freq[arr[i]] += 1

    count = 0

    for i in range(n):
        for j in range(i + 1, n):
            if freq[arr[i] + arr[j]]:
                count += 1

    return count


# Driver Code
if __name__ == '__main__':
    n = 4
    arr = [1, 5, 3, 2]

    # Function Call
    print(CountTriplets (arr, n))
