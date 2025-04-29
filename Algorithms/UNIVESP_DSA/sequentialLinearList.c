//*********************************
// sequentialLinearList.c
// This program manages sequential linear lists.
// The managed lists can have MAX elements (position of 0 to MAX - 1 in the array A).
// We inserted a MAX+1 positions on the Array to be able to use a sentinel element.
// *********************************

#define MAX 50
#include <stdio.h>
#include <stdbool.h>

typedef int KEYTYPE;

typedef struct{
        KEYTYPE key;
} RECORD;

typedef struct{
        RECORD A[MAX+1];
        int numberElements;
} LIST;


// Initialization
void initializeList(LIST* l) {
        l->numberElements = 0;
}

// Get number of elements
int lengthList(LIST* l) {
        return l->numberElements;
}

// Print LIST
void printList(LIST* l) {
        int i;
        printf("List: \" ");

        for(i = 0; i < l->numberElements; i++){
                printf("%i ", l->A[i].key);
        }
        printf("\"\n");
}

// Sequential search. It'll receive a key from the user and return the position of the element
// if the element is not found, it will return -one

int sequentialSearch(LIST* l, KEYTYPE k) {
        int i = 0;
        while (i < l->numberElements) {
                if(k == l->A[i].key) return i;
                else i++;
        }
        return -1;
}

// Element insertion. The user pass as a parameter the number to be inserted
// and the position to be inserted.
// If the list is not full and the position is valid,
// we push the elements from the right of the position indicated to the right
// then we can insert the number in the position indicated.

bool insertElement(LIST* l, RECORD rec, int i) {
        int j;
        if((l->numberElements == MAX) || (i < 0) || (i > l->numberElements))
                return false;
        for (j = l->numberElements; j > i; j--) l->A[j] = l->A[j-1];
        l->A[i] = rec;
        l->numberElements++;
        return true;
}
// Insert Element but ordenating elements before inserting
// it follows the logic of insertion sort
bool insertElementOrd(LIST* l, RECORD rec) {
        if(l->numberElements >= MAX) return false;
        int position = l->numberElements;
        while(position > 0 && l->A[position - 1].key > rec.key) {
                l->A[position] = l->A[position - 1];
                position--;
        }
        l->A[position] = rec;
        l->numberElements++;
        return true;
}

// Binary Search
int binarySearch(LIST* l, KEYTYPE k) {
        int left, mid, right;
        left = 0;
        right = l->numberElements - 1;
        while(left <= right){
                mid = ((left + right) / 2);
                if(l->A[mid].key == k) return mid;
                else {
                        if(l->A[mid].key > k) right = mid - 1;
                        else left = mid + 1;
                }
        }
        return -1;
}

// Element deletion. The user passes the element to be deleted and the list.
// If the element is in the list we can delete. After the deletion,
// we pull the elements to the left

bool deleteElementList(LIST* l, KEYTYPE k) {
        int check, j;
        check = binarySearch(l, k);
        if(check == -1) return false;

        for(j = check; j < l->numberElements - 1; j++)
                l->A[j] = l->A[j+1];

        l->numberElements--;
        return true;
}

// Reinitialize list
void reinitializeList(LIST* l) {
        l->numberElements = 0;
}

// Sentinel Search.
// the vector is created with MAX+1 positions
int sentinelSearch(LIST* l, KEYTYPE k) {
        int i = 0;
        l->A[l->numberElements].key != k; // sentinel
        while(l->A[i].key != k) i++;
        if (i > l->numberElements - 1) return -1; // not found
        else return i;
}

int listLengthBytes(LIST* l) {
        return sizeof(LIST);
}

int main() {
        LIST list;
        initializeList(&list);
        printList(&list);
        printf("Number of elements in list: %i.\n", lengthList(&list));
        printf("List length (in bytes): %i.\n", listLengthBytes(&list));

        RECORD rec;
        rec.key =  9;
        //insertElement(&list, rec, 0);
        insertElementOrd(&list, rec);
        printList(&list);

        rec.key =  12;
        //insertElement(&list, rec, 1);
        insertElementOrd(&list, rec);
        printList(&list);

        rec.key =  4;
        //insertElement(&list, rec, 2);
        insertElementOrd(&list, rec);
        printList(&list);

        rec.key =  60;
        //insertElement(&list, rec, 3);
        insertElementOrd(&list, rec);
        printList(&list);

        rec.key =  15;
        //insertElement(&list, rec, 2);
        insertElementOrd(&list, rec);
        printList(&list);

        printf("Number of elements in list: %i.\n", lengthList(&list));
        printf("List length (in bytes): %i.\n", listLengthBytes(&list));

        printf("Sequential Search - Key 4 found in position: %i of array A. \n", sequentialSearch(&list, 4));
        printf("Sentinel Search - Key 4 found in position: %i of array A. \n", sentinelSearch(&list, 4));

        if(deleteElementList(&list, 4)) printf("Successfully deleted: 4\n");
        if(deleteElementList(&list, 8)) printf("Successfully deleted: 8\n"); // will not run, 8 is not in the array
        if(deleteElementList(&list, 9)) printf("Successfully deleted: 9\n");

        printList(&list);

        printf("Number of elements in list: %i.\n", lengthList(&list));
        printf("List length (in bytes): %i.\n", listLengthBytes(&list));

        printf("Re-initializing list...\n");
        reinitializeList(&list);
        printList(&list);

        printf("Number of elements in list: %i.\n", lengthList(&list));
        printf("List length (in bytes): %i.\n", listLengthBytes(&list));

        return 0;
}