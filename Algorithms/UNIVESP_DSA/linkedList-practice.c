#include <stdio.h>
#include <malloc.h>

struct Node{
        int data;
        struct Node* next;
};


void printList(struct Node* head) {
        while(head != NULL) {
                printf("%i -> ", head->data);
                head = head->next;
        }
        printf("NULL \n");
}

void insertAtBeginning(struct Node** head, int value) {
        struct Node* newNode = (struct Node*)malloc(sizeof(struct Node));
        newNode->data = value;
        newNode->next = *head;

        *head = newNode;
}

void insertAtEnd(struct Node** head, int value) {
        struct Node* newNode = (struct Node*)malloc(sizeof(struct Node));

        newNode->data = value;
        newNode->next = NULL;

        if(*head == NULL) {
                *head = newNode;
                return;
        }

        struct Node* temp = *head;
        while(temp->next != NULL) {
                temp = temp->next;
        }

        temp->next = newNode;
}



int main() {
        struct Node* head = NULL;

        insertAtBeginning(&head, 5); // 5 -> NULL
        insertAtBeginning(&head, 10); // 10 -> 5 -> NULL
        insertAtEnd(&head, 200); // 10 -> 5 -> 200 -> NULL
        printList(head);

}