function solve(params) {
    var rows = parseInt(params[0]),
        cols = parseInt(params[1]),
        tests = parseInt(params[rows + 2]),
        i, move;
    var matrix = [];
    for (var row = 0; row < rows; row++) {
        var array = params[2 + row].split("");
        matrix[row] = [];
        for (var col = 0; col < cols; col++) {
            matrix[row][col] = array[col];
        }
    }

    for (i = 0; i < tests; i++) {
        move = params[rows + 3 + i].split(' ');

        var startRow = rows - move[0].substr(1);
        var startCol = move[0].charCodeAt(0) - 97;
        var endRow = rows - move[1].substr(1);
        var endCol = move[1].charCodeAt(0) - 97;

        if (matrix[startRow][startCol] === 'Q') {
            console.log("qween");
            //TODO create qween pattern
            //TODO check pattern and print yes or no
        } else if (matrix[startRow][startCol] === 'B') {
            console.log("Bishop");
            //TODO create bishop pattern
            //TODO check pattern and print yes or no
        } else if (matrix[startRow][startCol] === 'R') {
            console.log("Rook");
            //TODO create rook pattern
            //TODO check pattern and print yes or no
        } else {
            //here will be '-' which always print no cause of  empty square
            console.log('no');
        }
    }
}
solve([
    '5',
    '5',
    'Q---Q',
    '-----',
    '-B---',
    '--R--',
    'Q---Q',
    '10',
    'a1 a1',
    'a1 d4',
    'e1 b4',
    'a5 d2',
    'e5 b2',
    'b3 d5',
    'b3 a2',
    'b3 d1',
    'b3 a4',
    'c2 c5',
]);