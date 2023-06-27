function checkSudoku(matrix) {
    for (var i = 0; i < 9; i++) {
        for (var j = 0; j < 9; j++) {
            if (matrix[i][j] > 9 || matrix[i][j] < -1 || matrix[i][j] == 0) {
                return "Введенные данные вне допустимого диапазона";
            }
        }
    }
    for (var i = 0; i < 9; i++) {
        if (!RowChecking(matrix, i) || !ColChecking(matrix, i)) {
            return "Доска неправильная!";
        }
    }
    var set = new Set();
    for (var i = 0; i < 3; i++) {
        for (var j = 0; j < 3; j++) {
            if (matrix[i][j] == null) {
                continue;
            }
            if (set.has(matrix[i][j])) {
                return "Доска неправильная";
            }
            set.add(matrix[i][j]);
        }
    }
    set.clear();
    for (var i = 3; i < 6; i++) {
        for (var j = 3; j < 6; j++) {
            if (matrix[i][j] == null) {
                continue;
            }
            if (set.has(matrix[i][j])) {
                return "Доска неправильная";
            }
            set.add(matrix[i][j]);
        }
    }
    set.clear();
    for (var i = 6; i < 9; i++) {
        for (var j = 6; j < 9; j++) {
            if (matrix[i][j] == null) {
                continue;
            }
            if (set.has(matrix[i][j])) {
                return "Доска неправильная";
            }
            set.add(matrix[i][j]);
        }
    }
    set.clear();
    return "Доска правильная!";
}
function RowChecking(matrix, k) {
    var set = new Set();
    for (var i = 0; i < 9; i++) {
        if (matrix[k][i] == null) {
            continue;
        }
        if (set.has(matrix[k][i])) {
            return false;
        }
        set.add(matrix[k][i]);
    }
    return true;
}
function ColChecking(matrix, k) {
    var set = new Set();
    for (var i = 0; i < 9; i++) {
        if (matrix[i][k] == null) {
            continue;
        }
        if (set.has(matrix[i][k])) {
            return false;
        }
        set.add(matrix[i][k]);
    }
    return true;
}
var sud = [
    [5, 3, null, null, 7, null, null, null, null],
    [6, null, null, 1, 9, 5, null, null, null],
    [null, 5, 8, null, null, null, null, 6, null],
    [8, null, null, null, 6, null, null, null, 3],
    [4, null, null, 8, null, 3, null, null, 1],
    [7, null, null, null, 2, null, null, null, 6],
    [null, 6, null, null, null, null, 2, 8, null],
    [null, null, null, 4, 1, 9, null, null, 5],
    [null, null, null, null, 8, null, null, 7, 9],
];
console.log(checkSudoku(sud));
