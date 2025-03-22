//Bubble sort is a simple sorting algorithm that repeatedly steps through a list,
// compares adjacent items, and swaps them if they are in the wrong order.
// After each iteration the largest element goes to the end of the array...
// This means that after each iteration the array is one unsorted element shorter.
// N - 1 - iteration -> N - 1 | N - 2 | N - 3 | ...

// The sum of the numbers between 1 and 100 is always 101
// 100 + 1 = 101 | 99 + 2 = 101 | ... | 50 + 51 = 101
// Meaning (100 + 1)100/2
// Remember of Gauss... (N + 1)N/2
// But to calculate the time complexity we drop constants -> (N + 1)N = N² + N
// And then we drop non-significant values -> N²
// Meaning that the time complexity of the bubble sort algorithm is O(n²)

function bubbleSort(arr) {
  for (let i = 0; i < arr.length; ++i) {
    for (let j = 0; j < arr.length - 1 - i; ++j) {
      if (arr[j] > arr[j + 1]) {
        // Swap elements
        const temp = arr[j];
        arr[j] = arr[j + 1];
        arr[j + 1] = temp;
      }
    }
  }

  return arr;
}

// Creating unsorted array with the size of 100 to use as an example.
const size = 100;
const unsortedArr = [];

for (let i = 0; i < size; ++i) {
  // Using Math.random to generate numbers between 0 and 100
  unsortedArr.push(Math.floor(Math.random() * 100));
}

// Before sorting
console.log(unsortedArr);

// After sorting
console.log(bubbleSort(unsortedArr));
