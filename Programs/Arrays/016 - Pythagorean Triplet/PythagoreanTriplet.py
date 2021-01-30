import math


def checkTriplet(arr, n):
    maximum = 0

    for i in range(n):
        maximum = max(maximum, arr[i])

    hash = [0] * (maximum + 1)

    for i in range(n):
        hash[arr[i]] += 1

    for i in range(1, maximum + 1):
        if hash[i] == 0:
            continue

        for j in range (1, maximum + 1):
            if (i == j and hash[i] == 1) or hash[j] == 0:
                continue

            val = int(math.sqrt(i * i + j * j))

            if (val * val) != (i * i + j * j):
                continue

            if val > maximum:
                continue

            if hash[val]:
                return True
    return False


# Driver Code
arr = [3, 2, 4, 6, 5]
n = len(arr)
if checkTriplet(arr, n):
    print("Yes")
else:
    print("No")
