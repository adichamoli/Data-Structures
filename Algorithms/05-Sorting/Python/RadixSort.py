def CountSort(arr, expElem):
    size = len(arr)

    output = [0] * size
    count = [0] * 10

    for i in range(0, size):
        index = (arr[i] // expElem)
        count[int(index % 10)] += 1

    for i in range(1, 10):
        count[i] += count[i - 1]

    i = size - 1
    for i in range(size -1, -1, -1):
        index = arr[i] // expElem
        output[count[int(index % 10)] - 1] = arr[i]
        count[int(index % 10)] -= 1

    for i in range(0, size):
        arr[i] = output[i]


def RadixSort(arr):
    maxElem = max(arr)
    exp = 1

    while maxElem // exp > 0:
        CountSort(arr, exp)
        exp *= 10


def display(arr):
    for i in range(len(arr)):
        print(arr[i], end = " ")


# Driver code to test above
arr = [64, 34, 25, 12, 22, 11, 90]
print("Unsorted Array")
display(arr)
print()

RadixSort(arr)
display(arr)
print()