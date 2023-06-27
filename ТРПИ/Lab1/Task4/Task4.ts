function ArrayMedian(nums1:number[], nums2: number[]) : number {
    let array : number[] = nums1.concat(nums2);
    array.sort((a, b) => a - b);
    console.log(array);
    if (array.length % 2) {
        return array[Math.floor(array.length / 2)];
    } else {
        return (array[array.length / 2] + array[array.length / 2 - 1]) / 2;
    }
}

console.log(ArrayMedian([1,2], [3,4]));
console.log(ArrayMedian([1,3], [2]));