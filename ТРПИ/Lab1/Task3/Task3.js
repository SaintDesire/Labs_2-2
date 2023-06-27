function MoveArray(nums, k) {
    var temp = 0;
    for (var i = 0; i < k; i++) {
        temp = nums.pop();
        nums.unshift(temp);
    }
    console.log(nums);
}
MoveArray([1, 2, 3, 4, 5, 6, 7], 9);
