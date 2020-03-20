#include <stdio.h>
#include <stdlib.h>

// Data Structure to store a linked list node
struct Node
{
	int data;
	struct Node* next;
};

// Helper function to create a new node with the given data
struct Node* newNode(int data)
{
	// create a new linked list node from heap
	struct Node* node = (struct Node*)malloc(sizeof(struct Node));
	node->data = data;
	node->next = NULL;

	return node;
}

// Helper function to create a new node with the given data and
// pushes it onto the front of the list
void push(struct Node**headRef, int data)
{
	// create a new linked list node from heap
	struct Node* node = newNode(data);
	node->next = *headRef;
	*headRef = node;
}

// Helper function to print given linked list
void printList(struct Node* head)
{
	struct Node* ptr = head;
	while (ptr)
	{
		printf("%d -> ", ptr->data);
		ptr = ptr->next;
	}

	printf("null\n");
}

// Iterate through the list and move/insert each node to the
// front of the out list like a Push of the node
void reverse(struct Node** headRef)
{
	struct Node* out = NULL;
	struct Node* current = *headRef;

	// traverse the list
	while (current)
	{
		// tricky: note the next node
		struct Node* next = current->next;

		// move the current node onto the out
		current->next = out;
		out = current;

		// process next node
		current = next;
	}

	// fix head pointer
	*headRef = out;
}

// Function to add two lists X and Y
void add(struct Node* X, struct Node* Y, struct Node **head)
{
	// stores last seen node
	struct Node *prevNode = NULL;

	// initialize carry with 0
	int carry = 0;

	// run till both list are empty
	while (X || Y)
	{
		// sum is X's data + Y's data + carry (if any)
		int sum = 0;
		if (X)
			sum += X->data;
		if (Y)
			sum += Y->data;
		sum += carry;

		// if sum of 2-digit number, reduce it and update carry
		carry = sum / 10;
		sum = sum % 10;

		// create a new node with calculated sum
		struct Node *node = newNode(sum);

		// if the output list is empty
		if (*head == NULL)
		{
			// update prev and head pointers to point to the new node
			prevNode = node;
			*head = node;
		}
		else
		{
			// add new node to the output list
			prevNode->next = node;

			// update prev node to point to the new node
			prevNode = node;
		}

		// advance X and Y for next iteration of the loop
		if (X)
			X = X->next;
		
		if (Y)
			Y = Y->next;
	}

	if (carry != 0) {
		push(&(prevNode->next), carry);
	}
}

// Function to add two lists X and Y
struct Node* addLists(struct Node* X, struct Node* Y)
{
	struct Node* out = NULL;

	// reverse X and Y to access elements from the end
	reverse(&X);
	reverse(&Y);

	add(X, Y, &out);
	reverse(&out);
	
	// optional: call reverse again on X and Y

	return out;
}

// main method
int main(void)
{
	int x = 5734;
	int y = 946;

	// construct list X (5 -> 7 -> 3 -> 4) from number x
	struct Node* X = NULL;
	while (x)
	{
		push(&X, x % 10);
		x = x/10;
	}

	// construct list Y (9 -> 4 -> 6) from number y
	struct Node* Y = NULL;
	while (y)
	{
		push(&Y, y % 10);
		y = y/10;
	}

	printList(addLists(X, Y));

	return 0;
}