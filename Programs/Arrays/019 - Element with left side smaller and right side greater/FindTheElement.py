def findElement(a, n):
    if n == 1 or n == 2:
        return -1

    element, maxx, bit = a[0], a[0], -1
    check = 0
    idx = -1

    i = 1
    while i < (n - 1):
        if a[i] < maxx and i < (n - 1):
            i += 1
            bit = 0
        else:
            if a[i] >= maxx:
                element = a[i]
                idx = i
                check = 1
                maxx = a[i]

            if check == 1:
                i += 1

            bit = 1
            while a[i] >= element and i < (n - 1):
                if a[i] > maxx:
                    maxx = a[i]
                i += 1
            check = 0

    if element <= a[n - 1] and bit == 1:
        return idx + 1
    else:
        return -1


# Driver Code
if __name__ == '__main__':
    arr = [5, 1, 4, 3, 6, 8, 10, 7, 9]
    n = len(arr)

    print("Element : ", findElement(arr, n))
