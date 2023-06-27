function checkSudoku(matrix:number[][]) : string
{
    for(let i = 0; i < 9; i++)
    {
        for(let j = 0; j < 9; j++)
        {
            if(matrix[i][j] > 9 || matrix[i][j] < -1 || matrix[i][j] == 0)
            {
                return "Введенные данные вне допустимого диапазона";
            }
        }
    }

    for(let i = 0; i<9; i++)
    {
        if(!RowChecking(matrix, i) || !ColChecking(matrix, i))
        {
            return "Доска неправильная!";
        }
    }
    let set = new Set<number>();
        for(let i:number = 0; i < 3; i++) {
        for(let j:number = 0; j < 3; j++) {
            if(matrix[i][j] == null) {
                continue;
            }
            if(set.has(matrix[i][j])) {
                return "Доска неправильная";
            }
            set.add(matrix[i][j]);
        }
    }
        set.clear();
    for(let i:number = 3; i < 6; i++) {
        for(let j :number = 3; j < 6; j++) {
            if(matrix[i][j] == null) {
                continue;
            }
            if(set.has(matrix[i][j])) {
                return "Доска неправильная";
            }
            set.add(matrix[i][j]);
        }
    }
    set.clear();
    for(let i:number = 6; i < 9; i++) {
        for(let j:number = 6; j < 9; j++) {
            if(matrix[i][j] == null) {
                continue;
            }
            if(set.has(matrix[i][j])) {
                return "Доска неправильная";
            }
            set.add(matrix[i][j]);
        }
    }
    set.clear();

    return "Доска правильная!";
}

function RowChecking(matrix:number[][], k: number) : boolean
{
    let set = new Set<number>();

    for(let i = 0; i < 9; i++)
    {
        if(matrix[k][i] == null)
        {
            continue;
        }

        if(set.has(matrix[k][i]))
        {
            return false;
        }

        set.add(matrix[k][i]);
    }
    return true;
}

function ColChecking(matrix:number[][], k:number) : boolean
{
    let set = new Set<number>();

    for(let i = 0; i < 9; i++)
    {
        if(matrix[i][k] == null)
        {
            continue;
        }

        if(set.has(matrix[i][k]))
        {
            return false;
        }

        set.add(matrix[i][k]);
    }
    return true;
}

let sud: number[][] = [
    [5,3,null, null,7,null, null,null,null],
    [6,null,null, 1,9,5, null,null,null],
    [null,5,8, null,null,null, null,6,null],

    [8,null,null, null,6,null, null,null,3],
    [4,null,null, 8,null,3, null,null,1],
    [7,null,null, null,2,null, null,null,6],

    [null,6,null, null,null,null, 2,8,null],
    [null,null,null, 4,1,9, null,null,5],
    [null,null,null, null,8,null, null,7,9],
]

console.log(checkSudoku(sud));