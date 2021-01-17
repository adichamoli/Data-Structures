def search(arr, value):
    for i in range(0, len(arr)):
        if arr[i] == value:
            return i
    return -1


arr = [2, 3, 4, 10, 40]
x = 10

result = search(arr, x)
if result is -1:
    print("Element not found")
else:
    print("Element found at location : ", result + 1)