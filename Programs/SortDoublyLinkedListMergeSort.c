#include <stdio.h>
#include <stdlib.h>

// Data structure to store a node of the doubly linked list
struct Node {
    int data;
    struct Node *next, *prev;
};

// Utility function to push a node at the beginning of the doubly linked list
void push(struct Node** headRef, int key)
{
    struct Node* node = (struct Node*)malloc(sizeof(struct Node));
    node->data = key;
    node->prev = NULL;
    node->next = *headRef;

    // change prev of the existing head node to point to the new node
    if (*headRef != NULL)
        (*headRef)->prev = node;

    // update head pointer
    *headRef = node;
}

// Helper function to print nodes of a doubly linked list
void printDDL(struct Node* head)
{
    while (head != NULL)
    {
        printf("%d -> ", head->data);
        head = head->next;
    }

    printf("null\n");
}

// Function to split nodes of the given doubly linked list into
// two halves using the fast/slow pointer strategy
void split(struct Node* head, struct Node** a, struct Node** b)
{
    struct Node* slow = head;
    struct Node* fast = head->next;

    // Advance 'fast' by two nodes, and advance 'slow' by single node
    while (fast != NULL)
    {
        fast = fast->next;
        if (fast != NULL)
        {
            slow = slow->next;
            fast = fast->next;
        }
    }

    *b = slow->next;
    slow->next = NULL;
}

// Recursive function to merge nodes of two sorted lists together
// into a single sorted list
struct Node* merge(struct Node* a, struct Node* b)
{
    // Base cases
    if (a == NULL)
        return b;

    if (b == NULL)
        return a;

    // Pick either a or b, and recur
    if (a->data <= b->data)
    {
        a->next = merge(a->next, b);
        a->next->prev = a;
        a->prev = NULL;
        return a;
    }
    else
    {
        b->next = merge(a, b->next);
        b->next->prev = b;
        b->prev = NULL;
        return b;
    }
}

// Function to sort a doubly linked list using merge sort algorithm
void mergeSort(struct Node** head)
{
    // base case: 0 or 1 node
    if (*head == NULL || (*head)->next == NULL)
        return;

    // split head into 'a' and 'b' sublists
    struct Node *a = *head, *b = NULL;
    split(*head, &a, &b);

    // recursively sort the sub-lists
    mergeSort(&a);
    mergeSort(&b);

    // merge the two sorted lists together
    *head = merge(a, b);
}

// main function
int main(void)
{
    int keys[] = { 6, 4, 8, 7, 9, 2, 1 };
    int n = sizeof(keys)/sizeof(keys[0]);

    struct Node* head = NULL;
    for (int i = 0; i < n; i++)
        push(&head, keys[i]);

    mergeSort(&head);
    printDDL(head);

    return 0;
}