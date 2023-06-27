function FindMultipleNumbersSum(number) {
    var sum = 0;
    if (number < 0) {
        return 0;
    }
    for (var i = 0; i < number; i++) {
        if ((i % 3) == 0 && (i % 5) == 0) {
            sum -= i;
        }
        if ((i % 3) == 0 || (i % 5) == 0) {
            sum += i;
        }
    }
    return sum;
}
console.log(FindMultipleNumbersSum(46));
console.log(FindMultipleNumbersSum(-6));
