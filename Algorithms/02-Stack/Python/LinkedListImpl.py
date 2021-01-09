class Node:
    def __init__(self, data):
        self.data = data
        self.next = None

class Stack:
    def __init__(self):
        self.head = None

    def isEmpty(self):
        return self.head is None

    def push(self, data):
        if self.isEmpty():
            self.head = Node(data)
        else:
            node = Node(data)
            node.next = self.head
            self.head = node

    def pop(self):
        if self.isEmpty():
            return None
        else:
            poppedNode = self.head
            self.head = self.head.next
            poppedNode.next = None
            return poppedNode.data

    def peek(self):
        if self.isEmpty():
            return None
        else:
            return self.head.data

    def display(self):
        if self.isEmpty():
            print("Stack Underflow")
        else:
            node = self.head
            while node is not None:
                print("Element : ", node.data)
                node = node.next


# Driver code

if __name__=='__main__':
    MyStack = Stack()

    MyStack.push(11)
    MyStack.push(22)
    MyStack.push(33)
    MyStack.push(44)

    # Display stack elements
    MyStack.display()

    # Print top element of stack
    print ("Top element is ", MyStack.peek())

    # Delete top elements of stack
    MyStack.pop()
    MyStack.pop()

    # Display stack elements
    MyStack.display()

    # Print top element of stack
    print ("Top element is ", MyStack.peek())