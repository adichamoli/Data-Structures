#include <stdio.h>
#include <stdlib.h>

struct Node
{
    int data;
    struct Node *prev;
    struct Node *next;
};

struct Node *head = NULL;
struct Node *tail = NULL;

struct Node *createNode(int data)
{
    struct Node *node = (struct Node *)malloc(sizeof(struct Node));
    node->data = data;
    node->next = node->prev = NULL;
    return node;
}

void createSentinels()
{
    head = createNode(0);
    tail = createNode(0);
    head->next = tail;
    tail->prev = head;
}

void enqueueAtFront(int data)
{
    struct Node *node, *temp;
    node = createNode(data);
    temp = head->next;
    head->next = node;
    node->prev = head;
    node->next = temp;
    temp->prev = node;
}

void enqueueAtRear(int data)
{
    struct Node *node, *temp;
    node = createNode(data);
    temp = tail->prev;
    tail->prev = node;
    node->next = tail;
    node->prev = temp;
    temp->next = node;
}

void display()
{
    struct Node *temp;
    
    if(head->next == tail)
    {
        printf("Queue is Empty\n");
        return;
    }
    
    temp = head->next;
    while(temp != tail)
    {
        printf("Element : %d\n", temp->data);
        temp = temp->next;
    }
}

void dequeueAtFront()
{
    struct Node *temp;
    
    if(head->next == tail)
    {
        printf("Queue is Empty\n");
        return;
    }
    
    temp = head->next;
    head->next = temp->next;
    temp->next->prev = head;
    free(temp);
}

void dequeueAtRear()
{
    struct Node *temp;
    
    if(tail->prev == head)
    {
        printf("Queue is Empty\n");
        return;
    }
    
    temp = tail->prev;
    tail->prev = temp->prev;
    temp->prev->next = tail;
    free(temp);
}

int main() 
{
    createSentinels();
    enqueueAtFront(10);
    enqueueAtFront(20);
    enqueueAtFront(30);
    
    display();
    
    printf("Queue After Rear Insertion\n");
    enqueueAtRear(40);
    enqueueAtRear(50);
    
    display();
    
    dequeueAtFront();
    printf("Queue After Front Deletion\n");
    display();
    
    dequeueAtRear();
    printf("Queue After Rear Deletion\n");
    display();
    
    return 0;
}