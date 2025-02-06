// The Linear Search algorithm is a simple search method used to find a specific
// element in a list or array. It works by sequentially checking each element in the list,
// starting from the first one, and comparing it with the target element.

// Array or List does not need to be sorted.

// The time complexity for the Linear Search algorithm is O(N)
function linearSearch(arr, target) {
  for (let i = 0; i < arr.length; ++i) {
    if (arr[i] === target) return i; //returning position
  }
  return -1;
}

const arr = [1, 2, 3, 5, 6, 7, 8, 9, 20, 25, 30];
console.log(linearSearch(arr, 8)); // 6
console.log(linearSearch(arr, 33)); // -1
