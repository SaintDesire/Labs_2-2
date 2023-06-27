function MoveArray (nums : number[], k:number) : void {
    let temp: number = 0;
    for(let i: number = 0; i < k; i++) {
        temp = nums.pop();
        nums.unshift(temp);
    }
    console.log(nums);
}

MoveArray([1,2,3,4,5,6,7],9);