// The Binary Search algorithm is a search method used to find
// a target element in an array or list. It works by repeatedly dividing the search interval in half.
// Initially, it compares the target element with the middle element of the array.
// If the target is equal to the middle element, the search is complete.
// If the target is smaller, the search continues in the left half of the array,
// and if the target is larger, it continues in the right half.

// Array or List must be sorted.

// The time complexity of the Binary Search algorithm is O(logN)

function binarySearch(arr, start, end, target) {
  console.log(arr.slice(start, end)); // visualizing array

  if (start > end) return false;
  let midIndex = Math.floor((start + end) / 2);
  let value = arr[midIndex];
  if (value === target) return true;

  if (value > target) return binarySearch(arr, start, midIndex - 1, target);
  else return binarySearch(arr, midIndex + 1, end, target);
}

const arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 15, 18, 19, 43, 55];
const start = 0;
const end = arr.length - 1;

console.log(binarySearch(arr, start, end, 18)); // true
console.log(binarySearch(arr, start, end, 90)); // false

// Populating array arrP
const arrP = [];
for (let i = 1; i <= 1024; i++) {
  arrP.push(i);
}
const endP = arrP.length - 1;

console.log(binarySearch(arrP, start, endP, 845)); // true;
console.log(binarySearch(arrP, start, endP, 100000)); // false;
