def partition(arr, low, high):
    i = low - 1
    pivot = arr[high]

    for j in range(low, high):
        if arr[j] < pivot:
            i += 1
            arr[i], arr[j] = arr[j], arr[i]

    arr[i + 1], arr[high] = arr[high], arr[i + 1]
    return i + 1


def quickSort(arr, low, high):
    if low < high:
        pivot = partition(arr, low, high)

        quickSort(arr, low, pivot - 1)
        quickSort(arr, pivot + 1, high)


def display(arr):
    for i in range(0, len (arr)):
        print(arr[i], end= " ")


# Driver code to test above
arr = [64, 34, 25, 12, 22, 11, 90]
print("Unsorted Array")
display(arr)
print()

quickSort(arr, 0, len(arr) - 1)
print("Sorted Array")
display(arr)
print()