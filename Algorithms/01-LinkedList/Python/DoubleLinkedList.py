class Node:
    def __init__(self, data):
        self.data = data
        self.next = None
        self.prev = None

class DoubleLinkedList:
    def __init__(self):
        self.head = None

    def insertInEmptyList(self, data):
        if self.head is None:
            newNode = Node(data)
            self.head = newNode
        else:
            print("List is not Empty")

    def insertAtStart(self, data):
        if self.head is None:
            newNode = Node(data)
            self.head = newNode
            return

        newNode = Node(data)
        newNode.next = self.head
        self.head.prev = newNode
        self.head = newNode

    def insertAtEnd(self, data):
        if self.head is None:
            newNode = Node(data)
            self.head = newNode
            return

        node = self.head
        while node.next is not None:
            node = node.next

        newNode = Node(data)
        node.next = newNode
        newNode.prev = node

    def insertAfterItem(self, data, newData):
        if self.head is not None:
            print("List is Empty")
            return
        else:
            node = self.head
            while node is not None:
                if node.data == data:
                    break
                node = node.next

            if node is None:
                print("Item Not in List")
            else:
                newNode = Node(newData)
                newNode.prev = node
                newNode.next = node.next

                if node.next is not None:
                    node.next.prev = newNode

                node.next = newNode

    def insertBeforeItem(self, data, newData):
        if self.head is None:
            print("List is Empty")
            return
        else:
            node = self.head
            while node is not None:
                if node.data == data:
                    break
                node = node.next

            if node is None:
                print("Item Not in List")
            else:
                newNode = Node(newData)
                newNode.next = node
                newNode.prev = node.prev

                if node.prev is not None:
                    node.prev.next = newNode

                node.prev = newNode

    def traverseList(self):
        if self.head is None:
            print("List is Empty")
            return
        else:
            node = self.head
            while node is not None:
                print("Element : ", node.data)
                node = node.next

    def deleteFromStart(self):
        if self.head is None:
            print("List is Empty")

        if self.head.next is None:
            self.head = None
            return

        self.head = self.head.next
        self.head = None

    def deleteFromEnd(self):
        if self.head is None:
            print("List is Empty")
            return
        if self.head.next is None:
            self.head = None
            return

        node = self.head
        while node.next is not None:
            node = node.next

        node.prev.next = None

    def deleteByValue(self, data):
        if self.head is None:
            print("List is Empty")
            return

        if self.head.next is None:
            if self.head.data == data:
                self.head = None
            else:
                print("Item Not Found")
            return

        if self.head.data == data:
            self.head = self.head.next
            self.head.prev = None
            return

        node = self.head
        while node.next is not None:
            if node.data == data:
                break
            node = node.next

        if node.next is not None:
            node.prev.next = node.next
            node.next.prev = node.prev
        else:
            if node.data == data:
                node.prev.next = None
            else:
                print("Element not found")

    def reverseList(self):
        if self.head is None:
            print("List is Empty")
            return

        current = self.head
        previous = current.next
        current.next = None
        current.prev = previous

        while previous is not None:
            previous.prev = previous.next
            previous.next = current
            current = previous
            previous = previous.prev

        self.head = current

# Driver Function
if __name__=='__main__':
    linkedList = DoubleLinkedList()

    linkedList.insertInEmptyList(50)
    linkedList.insertAtStart(10)
    linkedList.insertAtStart(5)
    linkedList.insertAtStart(18)

    linkedList.insertAtEnd(29)
    linkedList.insertAtEnd(39)
    linkedList.insertAtEnd(49)

    linkedList.insertAfterItem(50, 65)
    linkedList.insertBeforeItem(29, 100)

    linkedList.traverseList()

    linkedList.deleteFromStart()
    linkedList.traverseList()

    linkedList.deleteFromEnd()
    linkedList.traverseList()

    linkedList.deleteByValue(65)
    linkedList.traverseList()

    linkedList.reverseList()
    linkedList.traverseList()