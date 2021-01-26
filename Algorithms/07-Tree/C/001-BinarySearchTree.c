#include <stdio.h>
#include <stdlib.h>

struct node {
   int data; 
	
   struct node *leftChild;
   struct node *rightChild;
};

struct node* root = NULL;

struct node* newNode(int item)
{
    struct node* temp
        = (struct node*)malloc(sizeof(struct node));
    temp->data = item;
    temp->leftChild = temp->rightChild = NULL;
    return temp;
}

struct node* insert(struct node* node, int key)
{
    /* If the tree is empty, return a new node */
    if (node == NULL)
        return newNode(key);
 
    /* Otherwise, recur down the tree */
    if (key < node->data)
        node->leftChild = insert(node->leftChild, key);
    else
        node->rightChild = insert(node->rightChild, key);
 
    /* return the (unchanged) node pointer */
    return node;
}

struct node* search(int data) {
   struct node *current = root;
   printf("Visiting elements: ");

   while(current->data != data) {
      if(current != NULL)
         printf("%d ",current->data); 

      //go to left tree
      if(current->data > data) {
         current = current->leftChild;
      }
      //else go to right tree
      else {                
         current = current->rightChild;
      }

      //not found
      if(current == NULL) {
         return NULL;
      }
   }
   
   return current;
}

struct node* minValueNode(struct node* node)
{
    struct node* current;
    
    while(current && current->leftChild != NULL)
        current = current->leftChild;
        
    return current;
}

struct node* deleteNode(struct node* root, int data)
{
    if(root == NULL)
        return root;
        
    if(data < root->data)
        root->leftChild = deleteNode(root->leftChild, data);
    
    else if(data > root->data)
        root->rightChild = deleteNode(root->rightChild, data);
    
    else
    {
        if(root->leftChild == NULL)
        {
            struct node* temp = root->rightChild;
            free(root);
            return temp;
        }
        else if(root->rightChild == NULL)
        {
            struct node* temp = root->leftChild;
            free(root);
            return temp;
        }
        
        struct node* temp = minValueNode(root->rightChild);
        root->data = temp->data;
        root->rightChild = deleteNode(root->rightChild, root->data);
    }
    return root;
}

void pre_order_traversal(struct node* root) {
   if(root != NULL) {
      printf("%d ",root->data);
      pre_order_traversal(root->leftChild);
      pre_order_traversal(root->rightChild);
   }
}

void inorder_traversal(struct node* root) {
   if(root != NULL) {
      inorder_traversal(root->leftChild);
      printf("%d ",root->data);          
      inorder_traversal(root->rightChild);
   }
}

void post_order_traversal(struct node* root) {
   if(root != NULL) {
      post_order_traversal(root->leftChild);
      post_order_traversal(root->rightChild);
      printf("%d ", root->data);
   }
}

int main() {
    int i = 0;
    
    root = insert(root, 50);
    root = insert(root, 30);
    root = insert(root, 20);
    root = insert(root, 40);
    root = insert(root, 70);
    root = insert(root, 60);
    root = insert(root, 80);

   i = 31;
   struct node * temp = search(i);

   if(temp != NULL) {
      printf("[%d] Element found.", temp->data);
      printf("\n");
   }else {
      printf("[ x ] Element not found (%d).\n", i);
   }

   i = 50;
   temp = search(i);

   if(temp != NULL) {
      printf("[%d] Element found.", temp->data);
      printf("\n");
   }else {
      printf("[ x ] Element not found (%d).\n", i);
   }            

   printf("\nPreorder traversal: ");
   pre_order_traversal(root);

   printf("\nInorder traversal: ");
   inorder_traversal(root);

   printf("\nPost order traversal: ");
   post_order_traversal(root);       


   root = deleteNode(root, 50);
   printf("\nInorder traversal After Deletion: ");
   inorder_traversal(root);
   
   return 0;
}