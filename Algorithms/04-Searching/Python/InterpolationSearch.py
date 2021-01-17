def interpolationSearch(arr, value, low, high):
    while (arr[high] != arr[low]) & (value >= arr[low]) & (value <= arr[high]):
        mid = low + ((value - arr[low]) * (high - low) // (arr[high] - arr[low]))

        if arr[mid] == value:
            return mid
        elif arr[mid] < value:
            low = mid + 1
        else:
            high = mid - 1
    return -1


def interpolationSearchRecursive(arr, value, low, high):
    if (arr[high] != arr[low]) & (value >= arr[low]) & (value <= arr[high]):
        mid = low + ((value - arr[low]) * (high - low) // (arr[high] - arr[low]))

        if arr[mid] == value:
            return mid
        elif arr[mid] > value:
            return interpolationSearchRecursive(arr, value, low, mid -1)
        else:
            return interpolationSearchRecursive(arr, value, mid + 1, high)
    else:
        return -1


arr = [2, 3, 4, 10, 40]
x = 40

# Function call
result = interpolationSearch(arr, x, 0, len(arr) - 1)

if result != -1:
    print("Element is present at index % d" % result)
else:
    print("Element is not present in array")

x = 10
result = interpolationSearchRecursive(arr, x, 0, len(arr) - 1)
if result != -1:
    print("Element is present at index % d" % result)
else:
    print("Element is not present in array")