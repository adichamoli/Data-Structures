#include <stdio.h>
#include <stdlib.h>

struct Node
{
    int data;
    struct Node *next;
};

struct Node* head;

void push(int data)
{
    struct Node *node = (struct Node *)malloc(sizeof(struct Node));
    
    if(node == NULL)
    {
        printf("Not able to add element.\n");
    }
    else
    {
        if(head == NULL)
        {
            node->data = data;
            node->next = NULL;
            head = node;
        }
        else
        {
            node->data = data;
            node->next = head;
            head = node;
        }
    }
}

void display()
{
    struct Node *node = head;
    
    if(node == NULL)
    {
        printf("Stack Underflow.\n");
    }
    
    while(node != NULL)
    {
        printf("Element : %d\n", node->data);
        node = node->next;
    }
}

void peek()
{
    printf("Topmost Element : %d\n", head->data);
}

void pop()
{
    struct Node *node = head;
    
    if(node == NULL)
    {
        printf("Stack Underflow\n");
    }
    else
    {
        head = head->next;
        free(node);
    }
    
}

int main()
{
    push(3);
    push(4);
    display();
    peek();
    push(7);
    display();
    peek();
    pop();
    display();
}