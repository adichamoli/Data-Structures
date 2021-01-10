from queue import Queue

queue = Queue(maxsize=10)

print("Queue Size     : ", queue.qsize())
print("Queue Capacity : ", queue.maxsize)

queue.put(10)
queue.put(20)
queue.put(30)

for item in queue.queue:
    print("Element        : ", item)

print("Queue Elements : ", list(queue.queue))

print("Popped Element : ", queue.get())

print("Is Queue Empty : ", queue.empty())
print("Is Queue Full  : ", queue.full())

queue.put_nowait(40)
queue.put_nowait(50)
queue.put_nowait(60)

print("Queue Elements : ", list(queue.queue))

print("Popped Element : ", queue.get_nowait())