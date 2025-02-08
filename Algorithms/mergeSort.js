// Merge Sort is a divide and conquer sorting algorithm that recursively divides an unsorted list into two halves,
// sorts each half, and then merges them back together in sorted order.

// The time complexity of Merge Sort algorithm is O(N Log N)

function MergeSort(arr) {
  console.log("MERGE SORT");
  console.log(arr);

  if (arr.length < 2) {
    return arr;
  }

  // Divide and conquer
  const midIndex = Math.floor(arr.length / 2);
  const leftArr = arr.slice(0, midIndex);
  const rightArr = arr.slice(midIndex, arr.length);

  console.log(leftArr, rightArr);

  return Merge(MergeSort(leftArr), MergeSort(rightArr));
}

function Merge(leftArr, rightArr) {
  console.log("MERGE");

  console.log(leftArr, rightArr);
  let resultArr = [];
  let leftIndex = 0;
  let rightIndex = 0;

  while (leftIndex < leftArr.length && rightIndex < rightArr.length) {
    if (leftArr[leftIndex] < rightArr[rightIndex]) {
      resultArr.push(leftArr[leftIndex]);
      leftIndex++;
    } else {
      //meaning: rightArr[rightIndex] < leftArr[leftIndex]
      resultArr.push(rightArr[rightIndex]);
      rightIndex++;
    }
  }
  resultArr = resultArr.concat(
    leftArr.slice(leftIndex).concat(rightArr.slice(rightIndex))
  );
  console.log(resultArr);
  return resultArr;
}

const arr = [6, 0, 23, 21, 14];
MergeSort(arr);
