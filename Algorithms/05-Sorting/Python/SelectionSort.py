def SelectionSort(arr):
    size = len(arr)

    for i in range(0, size - 1):
        min_index = i
        for j in range( i + 1, size):
            if arr[j] < arr[min_index]:
                min_index = j

        arr[i], arr[min_index] = arr[min_index], arr[i]


def display(arr):
    for i in range(len(arr)):
        print(arr[i], end = " ")


# Driver code to test above
arr = [64, 34, 25, 12, 22, 11, 90]
print("Unsorted Array")
display(arr)
print()

SelectionSort(arr)
display(arr)
print()