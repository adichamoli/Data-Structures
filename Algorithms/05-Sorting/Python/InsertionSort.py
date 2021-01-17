def InsertionSort(arr):
    size = len(arr)

    for i in range(1, size):
        key = arr[i]
        j = i - 1

        while j >= 0 and arr[j] > key:
            arr[j + 1] = arr[j]
            j = j - 1

        arr[j + 1] = key

def display(arr):
    for i in range(len(arr)):
        print(arr[i], end = " ")


# Driver code to test above
arr = [64, 34, 25, 12, 22, 11, 90]
print("Unsorted Array")
display(arr)
print()

InsertionSort(arr)
print("Sorted Array")
display(arr)
print()