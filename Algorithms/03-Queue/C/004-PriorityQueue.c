#include <stdio.h>
#include <stdlib.h>

struct Node
{
    int data;
    int priority;
    struct Node* next; 
};

struct Node* newNode(int data, int priority)
{
    struct Node* node = (struct Node *)malloc(sizeof(struct Node));
    node->data = data;
    node->priority = priority;
    node->next = NULL;
    
    return node;
}

int peek(struct Node** head)
{
    return (*head)->data;
}

void pop(struct Node** head)
{
    struct Node* node = *head;
    *head = (*head)->next;
    free(node);
}

void push(struct Node** head, int data, int priority)
{
    struct Node* start = *head;
    
    struct Node* node = newNode(data, priority);
    
    if((*head)->priority > priority)
    {
        node->next = *head;
        *head = node;
    }
    else
    {
        while(start->next != NULL &&
              start->next->priority < priority)
        {
            start = start->next;
        }
        
        node->next = start->next;
        start->next = node;
    }
}

int isEmpty(struct Node** head) 
{ 
    return (*head) == NULL; 
} 

void display(struct Node** head)
{
    struct Node* node = *head;
    while(node != NULL)
    {
        printf("Element : %d   Priority : %d\n", node->data, node->priority);
        node = node->next;
    }
}

int main() 
{ 
    struct Node* pq = newNode(4, 1); 
    push(&pq, 5, 2); 
    push(&pq, 6, 3); 
    push(&pq, 7, 0); 
    
    display(&pq);
 
    printf("TopMost Element : %d\n", peek(&pq)); 
    pop(&pq); 
 
    printf("Queue After Deletion\n");
    display(&pq);
 
    return 0; 
} 