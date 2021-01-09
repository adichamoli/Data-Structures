from collections import deque
myStack = deque()

myStack.append(10)
myStack.append(20)
myStack.append(30)

print(myStack)
print("No of Elements ", len(myStack))
print("TopMost Element ", myStack[-1])

myStack.pop()
myStack.pop()

print(myStack)
myStack.pop()