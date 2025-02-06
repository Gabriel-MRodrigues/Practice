// The Binary Search algorithm is a search method used to find
// a target element in an array or list. It works by repeatedly dividing the search interval in half.
// Initially, it compares the target element with the middle element of the array.
// If the target is equal to the middle element, the search is complete.
// If the target is smaller, the search continues in the left half of the array,
// and if the target is larger, it continues in the right half.

// Array or List must be sorted.

// The time complexity of the Binary Search algorithm is O(logN)

function binarySearch(arr, target) {
  let lo = 0;
  let hi = arr.length;

  do {
    const m = Math.floor(lo + (hi - lo) / 2);
    const v = arr[m];

    if (v === target) return true;
    else if (v > target) {
      hi = m;
    } else {
      // meaning v < target
      lo = m + 1;
    }
  } while (lo < hi);

  return false;
}

const arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 15, 17, 18, 26, 33, 41];
console.log(binarySearch(arr, 8)); // true
console.log(binarySearch(arr, 19)); // false

// Populating array arrP
const arrP = [];
for (let i = 1; i <= 1024; i++) {
  arr.push(i);
}

console.log(binarySearch(arrP, 216)); // true
console.log(binarySearch(arrP, 10000)); // false
