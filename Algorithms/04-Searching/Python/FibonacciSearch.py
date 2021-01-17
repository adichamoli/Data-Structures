def fibonacciSearch(arr, value):
    size = len(arr)

    fibMM2 = 0;
    fibMM1 = 1;
    fibM = fibMM1 + fibMM2
    offset = -1

    while fibM < size:
        fibMM2 = fibMM1;
        fibMM1 = fibM;
        fibM = fibMM1 + fibMM2

    while fibM > 1:
        i = min(offset + fibMM2, size -1)

        if arr[i] < value:
            fibM = fibMM1
            fibMM1 = fibMM2
            fibMM2 = fibM - fibMM1
            offset = i
        elif arr[i] > value:
            fibM = fibMM2
            fibMM1 = fibMM1 - fibMM2
            fibMM2 = fibM - fibMM1
        else:
            return i

    if fibMM1 and arr[offset + 1] == value:
        return offset + 1

    return -1


arr = [2, 3, 4, 10, 40]
x = 40

# Function call
result = fibonacciSearch(arr, x)

if result != -1:
    print("Element is present at index % d" % result)
else:
    print("Element is not present in array")