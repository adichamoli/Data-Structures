s = "i like this program very much"
words = s.split(' ')
string = []
for word in words:
    string.insert(0, word)

print("Reversed String:")
print(" ".join(string))


# Without Using Extra Space
def RevString(s):
    l = len(s)
    j = int(l // 2)

    while j <= l - 1:
        s[j], s[l - j - 1] = s[l - j - 1], s[j]
        j += 1

    return s


# Driver Code
s = 'getting good at coding needs a lot of'
string = s.split(' ')
string = RevString(string)
print(" ".join(string))
