class Node:
    def __init__(self, key):
        self.key = key
        self.leftChild = None
        self.rightChild = None

    def insert(self, key):
        if self.key:
            if key < self.key:
                if self.leftChild is None:
                    self.leftChild = Node(key)
                else:
                    self.leftChild.insert(key)
            elif key > self.key:
                if self.rightChild is None:
                    self.rightChild = Node(key)
                else:
                    self.rightChild.insert(key)
        else:
            self.key = key

    def inOrder(self, root):
        if root:
            self.inOrder(root.leftChild)
            print(root.key, end=" ")
            self.inOrder(root.rightChild)

    def preOrder(self, root):
        if root:
            print(root.key, end=" ")
            self.preOrder(root.leftChild)
            self.preOrder(root.rightChild)

    def postOrder(self, root):
        if root:
            self.postOrder(root.leftChild)
            self.postOrder(root.rightChild)
            print(root.key, end=" ")

    def search(self, key):
        if key < self.key:
            if self.leftChild is None:
                return -1
            return self.leftChild.search(key)
        elif key > self.key:
            if self.rightChild is None:
                return -1
            return self.rightChild.search(key)
        else:
            return self.key


# Driver program to test the above functions
# Let us create the following BST
# 50
# /	 \
# 30	 70
# / \ / \
# 20 40 60 80

r = Node(50)
r.insert(30)
r.insert(20)
r.insert(40)
r.insert(70)
r.insert(60)
r.insert(80)

# Print inoder traversal of the BST
print("InOrder Traversal")
r.inOrder(r)
print("")

print("PreOrder Traversal")
r.preOrder(r)
print("")

print("PostOrder Traversal")
r.postOrder(r)
print("")

print("Search 50 in Tree")
result = r.search(50)

if result == -1:
    print("Element Not Found")
else:
    print("Element Found")

print("Search 10 in Tree")
result = r.search(10)

if result == -1:
    print("Element Not Found")
else:
    print("Element Found")
