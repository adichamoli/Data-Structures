def merge(arr, left, mid, right):
    n1 = mid - left + 1
    n2 = right - mid

    first = [0] * (n1)
    second = [0] * (n2)

    for i in range(0, n1):
        first[i] = arr[left + i]

    for i in range(0, n2):
        second[i] = arr[mid + 1 + i]

    i = 0
    j = 0
    k = left

    while i < n1 and j < n2:
        if first[i] <= second[j]:
            arr[k] = first[i]
            i += 1
        else:
            arr[k] = second[j]
            j += 1
        k += 1

    while i < n1:
        arr[k] = first[i]
        i += 1
        k += 1

    while j < n2:
        arr[k] = second[j]
        j += 1
        k += 1


def mergeSort(arr, left, right):
    if left < right:
        mid = (left + (right - 1)) // 2

        mergeSort(arr, left, mid)
        mergeSort(arr, mid + 1, right)

        merge(arr, left, mid, right)


def display(arr):
    for i in range(0, len (arr)):
        print(arr[i], end= " ")


# Driver code to test above
arr = [64, 34, 25, 12, 22, 11, 90]
print("Unsorted Array")
display(arr)
print()

mergeSort(arr, 0, len(arr) - 1)
print("Sorted Array")
display(arr)
print()