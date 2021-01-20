def ShellSort(arr):
    size = len(arr)
    gap = size // 2

    while gap > 0:
        for i in range(gap, size):
            temp = arr[i]
            j = i
            while j >= gap and arr[j - gap] > temp:
                arr[j] = arr[j - gap]
                j -= gap
            arr[j] = temp
        gap //= 2


def display(arr):
    for i in range(len(arr)):
        print(arr[i], end = " ")


# Driver code to test above
arr = [64, 34, 25, 12, 22, 11, 90]
print("Unsorted Array")
display(arr)
print()

ShellSort(arr)
display(arr)
print()