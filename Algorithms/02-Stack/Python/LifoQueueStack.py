from queue import LifoQueue

myStack = LifoQueue()

myStack.put(10)
myStack.put(20)
myStack.put(30)

for i in myStack.queue[::-1]:
    print("Element ", i)

print("TopMost Element ", myStack.queue[-1])

myStack.get()
myStack.get()

for i in myStack.queue[::-1]:
    print("Element ", i)

print("TopMost Element ", myStack.queue[-1])

myStack.get()
