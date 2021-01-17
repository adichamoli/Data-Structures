def binarySearch(arr, value, low, high):
    while low <= high:
        mid = low + (high - low) // 2

        if arr[mid] == value:
            return mid
        elif arr[mid] < value:
            low = mid + 1
        else:
            high = mid - 1
    return -1


def binarySearchRecursive(arr, value, low, high):
    if low <= high:
        mid = low + (high - low) // 2

        if arr[mid] == value:
            return mid
        elif arr[mid] > value:
            return binarySearchRecursive(arr, value, low, mid -1)
        else:
            return binarySearchRecursive(arr, value, mid + 1, high)
    else:
        return -1


arr = [2, 3, 4, 10, 40]
x = 10

# Function call
result = binarySearch(arr, x, 0, len(arr) - 1)

if result != -1:
    print("Element is present at index % d" % result)
else:
    print("Element is not present in array")

result = binarySearchRecursive(arr, x, 0, len(arr) - 1)
if result != -1:
    print("Element is present at index % d" % result)
else:
    print("Element is not present in array")