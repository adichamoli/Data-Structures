class Node:
    def __init__(self, data = None, next = None):
        self.data = data
        self.next = next

class LinkedList:
    def __init__(self):
        self.head = None

    def traverseList(self):
        if self.head is None:
            print("List has no elements")
            return
        else:
            node = self.head
            while node is not None:
                print("Element : ", node.data)
                node = node.next

    def insertAtStart(self, data):
        new_node = Node (data)
        new_node.next = self.head
        self.head = new_node

    def insertAtEnd(self, data):
        new_node = Node(data)
        if self.head is None:
            self.head = new_node
            return
        temp = self.head
        while temp.next is not None:
            temp = temp.next

        temp.next = new_node

    def insertAfterItem(self, x, data):
        node = self.head
        while node is not None:
            if node.data == x:
                break
            node = node.next

        if node is None:
            print("Item not in list")
        else:
            newNode = Node(data)
            newNode.next = node.next
            node.next = newNode

    def insertBeforeItem(self, x, data):
        if self.head is None:
            print("List is Empty")
            return

        if x == self.head.data:
            newNode = Node(data)
            newNode.next = self.head
            self.head = newNode
            return

        node = self.head
        while node.next is not None:
            if node.next.data == x:
                break
            node = node.next

        if node.next is None:
            print("Item not in list")
        else:
            newNode = Node (data)
            newNode.next = node.next
            node.next = newNode

    def insertAtIndex(self, index, data):
        if index == 1:
            newNode = Node(data)
            newNode.next = self.head
            self.head = newNode

        i = 1
        node = self.head

        while i < index - 1 and node is not None:
            node = node.next
            i = i + 1

        if node is None:
            print("Index Out of Bound")
        else:
            newNode = Node(data)
            newNode.next = node.next
            node.next = newNode

    def countElements(self):
        if self.head is None:
            return 0

        node = self.head
        count = 0
        while node is not None:
            count = count + 1
            node = node.next

        return count

    def searchItem(self, data):
        if self.head is None:
            print("List is Empty")
            return

        node = self.head
        while node is not None:
            if node.data == data:
                print("Item Found")
                return
            node = node.next

        print("Item not found")
        return

    def deleteAtStart(self):
        if self.head is None:
            print("List is Empty")
            return

        self.head = self.head.next

    def deleteAtEnd(self):
        if self.head is None:
            print("List is Empty")
            return

        node = self.head
        while node.next.next is not None:
            node = node.next

        node.next = None

    def deleteByValue(self, data):
        if self.head is None:
            print("List is Empty")
            return

        if self.head.data == data:
            self.head = self.head.next
            return

        node = self.head
        while node.next is not None:
            if node.next == data:
                break
            node = node.next

        if node.next is None:
            print("Item not found in list")
        else:
            node.next = node.next.next

    def revereList(self):
        prev = None
        node = self.head

        while node is not None:
            next = node.next
            node.next = prev
            prev = node
            node = next

        self.head = prev
# Driver Function
if __name__=='__main__':
    linkedList = LinkedList()

    linkedList.insertAtStart(4)
    linkedList.insertAtEnd(5)
    linkedList.insertAtEnd(6)
    linkedList.insertAfterItem(4, 2)
    linkedList.insertBeforeItem (6, 3)
    linkedList.insertAtIndex (3, 30)
    linkedList.traverseList()

    print("No. of Elements in List ", linkedList.countElements())

    linkedList.searchItem(5)
    linkedList.searchItem(8)

    print("Deleting Element at Start")
    linkedList.deleteAtStart()
    linkedList.traverseList()
    print ("No. of Elements in List ", linkedList.countElements ())

    print ("Deleting Element at End")
    linkedList.deleteAtEnd()
    linkedList.traverseList()
    print ("No. of Elements in List ", linkedList.countElements ())

    print ("Deleting Element at End")
    linkedList.deleteByValue(30)
    linkedList.traverseList()
    print ("No. of Elements in List ", linkedList.countElements ())

    linkedList.deleteByValue(10)

    print ("Reversing the List")
    linkedList.revereList()
    linkedList.traverseList()