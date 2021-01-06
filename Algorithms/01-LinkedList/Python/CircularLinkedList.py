import random

class Node:
    def __init__(self, data):
        self.data = data
        self.next = Node

class CircularList:
    def __init__(self, node=None):
        self.head = node
        if node:
            node.next = self.head

    def isEmpty(self):
        return self.head == None

    def length(self):
        if self.isEmpty():
            return 0

        count = 1
        current = self.head

        while current.next is not self.head:
            count += 1
            current =  current.next

        return count

    def traverse(self):
        if self.isEmpty():
            print("List is Empty")

        current = self.head
        while current.next is not self.head:
            print("Element : ", current.data)
            current = current.next

    def headInsert(self, data):
        node = Node(data)

        if self.isEmpty():
            self.head = node
            node.next = node
        else:
            current = self.head
            while current.next is not self.head:
                current = current.next

            node.next = self.head
            self.head = node
            current.next = self.head

    def tailInsert(self, data):
        node = Node(data)

        if self.isEmpty():
            self.head = node
            node.next = self.head
        else:
            current = self.head
            while current.next is not self.head:
                current = current.next

            current.next = node
            node.next = self.head

    def nodeInsert(self, data, index):
        if index <= 0:
            self.headInsert(data)
        elif index > self.length()-1:
            self.tailInsert(data)
        else:
            current = self.head
            count = 0
            while count < index-1:
                count += 1
                current = current.next

            node = Node(data)
            node.next = current.next
            current.next = node

    def removeByValue(self, val):
        if self.isEmpty():
            print('Not found value!')
            return
        current = self.head
        pre = None

        if current.data == val:
            if current.next != self.head:
                while current.next != self.head:
                    current = current.next
                current.next = self.head.next
                self.head = self.head.next
            else:
                self.head = None
        else:
            pre = self.head
            while current.next != self.head:
                if current.data == val:
                    pre.next = current.next
                    return
                else:
                    pre = current
                    current = current.next
            if current.data == val:
                pre.next = current.next
        print('Not found value!')


circularList = CircularList()
for i in range(6):
    circularList.tailInsert(random.randint(0,10))
circularList.traverse()
circularList.nodeInsert(100,5)
print("List After Adding 100")
circularList.traverse()

circularList.removeByValue(100)
print("List after deleting first Element")
circularList.traverse()
