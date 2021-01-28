def rearrange(arr, n):
    max_idx = n -1
    min_idx = 0

    max_ele = arr[max_idx] + 1

    for i in range(n):
        if i % 2 == 0:
            arr[i] += (arr[max_idx] % max_ele) * max_ele
            max_idx -= 1
        else:
            arr[i] += (arr[min_idx] % max_ele) * max_ele
            min_idx += 1

    for i in range(0, n):
        arr[i] = arr[i] / max_ele


# Driver Code
arr = [1, 2, 3, 4, 5, 6, 7, 8, 9]
n = len(arr)

print("Original Array")

for i in range(0, n):
    print(arr[i], end=" ")

rearrange(arr, n)

print("\nModified Array")
for i in range(0, n):
    print(int(arr[i]), end=" ")
