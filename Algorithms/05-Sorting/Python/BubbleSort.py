def bubbleSort(arr):
    size = len(arr)

    for i in range(0, size - 1):
        for j in range(0, size - 1 - i):
            if arr[j] > arr[j + 1]:
                arr[j], arr[j + 1] = arr[j + 1], arr[j]


def bubbleSortOptimized(arr):
    size = len(arr)

    for i in range(0, size - 1):
        swapped = False
        for j in range(0, size - 1 - i):
            if arr[j] > arr[j + 1]:
                arr[j], arr[j + 1] = arr[j + 1], arr[j]
                swapped = True
        if swapped is False:
            break


def display(arr):
    for i in range(0, len (arr)):
        print(arr[i], end= " ")


# Driver code to test above
arr = [64, 34, 25, 12, 22, 11, 90]
print("Unsorted Array")
display(arr)
print()

bubbleSort(arr)
print("Sorted Array")
display(arr)
print()

arr = [64, 34, 25, 12, 22, 11, 90]
print("Unsorted Array")
display(arr)
print()
bubbleSortOptimized(arr)
print("Sorted Array")
display(arr)
print()