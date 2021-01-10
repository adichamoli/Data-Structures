class Queue:
    def __init__(self, size):
        self.queue = [None] * size
        self.capacity = size
        self.front = 0
        self.rear = -1
        self.count = 0

    def size(self):
        return self.count

    def isEmpty(self):
        return self.size() == 0

    def isFull(self):
        return self.size() == self.capacity

    def append(self, data):
        if self.isFull():
            print("Queue OverFlow")
            exit(1)

        self.rear = (self.rear + 1) % self.capacity
        self.queue[self.rear] = data
        self.count += 1

    def pop(self):
        if self.isEmpty():
            print("Queue Underflow")
            exit(1)
        else:
            self.front = (self.front + 1) % self.capacity
            self.count -= 1

    def peek(self):
        if self.isEmpty():
            print("Queue Underflow")
            exit(1)
        else:
            return self.queue[self.front]

    def display(self):
        if self.isEmpty():
            print("Queue Underflow")
            exit(1)
        else:
            for i in range (0, self.rear + 1):
                print("Element : ", self.queue[i])


if __name__ == '__main__':

    # create a queue of capacity 5
    queue = Queue(5)

    queue.append(1)
    queue.append(2)
    queue.append(3)

    print("Queue size is", queue.size())
    print("Front element is", queue.peek())

    queue.display()

    queue.pop()
    print("Front element is", queue.peek())

    queue.pop()
    queue.pop()

    if queue.isEmpty():
        print("Queue is empty")
    else:
        print("Queue is not empty")