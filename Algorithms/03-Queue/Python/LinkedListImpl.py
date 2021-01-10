class Node:

    def __init__(self, data):
        self.data = data
        self.next = None


class Queue:

    def __init__(self):
        self.front = self.rear = None

    def isEmpty(self):
        return self.front is None

    def Enqueue(self, data):
        node = Node(data)

        if self.rear is None:
            self.front = self.rear = node
            return

        self.rear.next = node
        self.rear = node

    def Dequeue(self):
        if self.isEmpty():
            return

        node = self.front
        self.front = node.next

        if self.front is None:
            self.rear = None

    def Display(self):
        if self.isEmpty():
            print("Queue is Empty")
            return

        node = self.front

        while node is not None:
            print("Element : ", node.data);
            node = node.next;


# Driver Code
if __name__== '__main__':
    queue = Queue()
    queue.Enqueue(10)
    queue.Enqueue(20)
    queue.Display()

    queue.Dequeue()
    queue.Dequeue()
    queue.Display ()

    queue.Enqueue(30)
    queue.Enqueue(40)
    queue.Enqueue(50)

    queue.Display ()
    queue.Dequeue()
