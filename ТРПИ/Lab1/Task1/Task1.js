function CreateNumber(number) {
    if (number.length != 10) {
        return null;
    }
    var phone = "(";
    for (var i = 0; i < 10; i++) {
        if (i == 3) {
            phone += ") ";
        }
        if (i == 6) {
            phone += "-";
        }
        phone += number[i];
    }
    console.log(phone);
}
;
CreateNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]);
