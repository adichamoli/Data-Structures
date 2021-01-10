from collections import deque

queue = deque(maxlen=10)

print("Queue Size     : ", queue.__len__())

queue.append(10)
queue.append(20)
queue.append(30)

print("Queue Size     : ", queue.__len__())
print("No of Times 10 : ", queue.count(10))

for item in queue:
    print("Element        : ", item)

print("Queue Elements : ", list(queue))

print("Popped Element : ", queue.pop())
print("Popped Element : ", queue.popleft())

print("Queue Empty    : ", queue.clear())

print("Queue Elements : ", list(queue))