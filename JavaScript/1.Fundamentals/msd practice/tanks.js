function solve(args) {
    var rowsAndCows = args[0].split(' ').map(Number);
    var rows = rowsAndCows[0];
    var cols = rowsAndCows[1];

    var matrix = [];
    for (var i = 0; i < rows; i++) {
        matrix[i] = [];
        for (var j = 0; j < cols; j++) {
            matrix[i][j] = '-';
        }
    }
    matrix[0][0] = 'K0';
    matrix[0][1] = 'K1';
    matrix[0][2] = 'K2';
    matrix[0][3] = 'K3';
    matrix[rows - 1][cols - 4] = 'C7';
    matrix[rows - 1][cols - 3] = 'C6';
    matrix[rows - 1][cols - 2] = 'C5';
    matrix[rows - 1][cols - 1] = 'C4'; //can be optimized can be without a matrix but not now
    var debris = args[1].split(';');
    for (var index = 0; index < debris.length; index++) {
        var debrisPos = debris[index].split(' ').map(Number);
        var debrisRow = debrisPos[0];
        var debrisCol = debrisPos[1];
        matrix[debrisRow][debrisCol] = 'D';
    }
    var commands = +args[2];
    var tanks = [
        [0, 0],
        [0, 1],
        [0, 2],
        [0, 3],
        [rows - 1, cols - 1],
        [rows - 1, cols - 2],
        [rows - 1, cols - 3],
        [rows - 1, cols - 4],
    ];
    var Cuki = 4;
    var Kon = 4;

    for (var moves = 3; moves < args.length; moves++) {
        var command = args[moves].split(' ');
        var moveOrShoot = command[0];


        if (moveOrShoot === 'mv') {
            var idMove = +command[1];
            var tank = matrix[tanks[idMove][0]][tanks[idMove][1]];
            matrix[tanks[idMove][0]][tanks[idMove][1]] = '-';
            var rowMove = tanks[idMove][0];
            var colMove = tanks[idMove][1];

            var n = +command[2];
            var dirMove = command[3];
            while (n > 0) {
                if (dirMove === 'u') {
                    rowMove--;
                    if (matrix[rowMove][colMove] !== "-") {
                        rowMove++;

                        break;
                    }
                }
                if (dirMove === 'd') {
                    rowMove++;
                    if (matrix[rowMove][colMove] !== "-") {
                        rowMove--;

                        break;
                    }
                }
                if (dirMove === 'l') {
                    colMove--;
                    if (matrix[rowMove][colMove] !== "-") {
                        colMove++;

                        break;
                    }
                }
                if (dirMove === 'r') {
                    colMove++;
                    if (matrix[rowMove][colMove] !== "-") {
                        colMove--;
                        break;
                    }
                }
                n--;
            }
            matrix[rowMove][colMove] = tank;
            tanks[idMove][0] = rowMove;
            tanks[idMove][1] = colMove;


        } else if (moveOrShoot === 'x') {
            var idShoot = command[1];
            var dirShoot = command[2];
            var rowShoot = tanks[idShoot][0];
            var colShoot = tanks[idShoot][1];
            while (true) {
                if (dirShoot === 'u') {
                    rowShoot--;
                    if (rowShoot === 0) {
                        break;
                    }
                    if (matrix[rowShoot][colShoot] !== "-") {
                        break;
                    }
                }
                if (dirShoot === 'd') {
                    rowShoot++;
                    if (rowShoot === rows - 1) {
                        break;
                    }
                    if (matrix[rowShoot][colShoot] !== "-") {
                        break;
                    }
                }
                if (dirShoot === 'l') {
                    colShoot--;
                    if (colShoot === 0) {
                        break;
                    }
                    if (matrix[rowShoot][colShoot] !== "-") {
                        break;
                    }
                }
                if (dirShoot === 'r') {
                    colShoot++;
                    if (colShoot === cols - 1) {
                        break;
                    }
                    if (matrix[rowShoot][colShoot] !== "-") {
                        break;
                    }
                }
            }
            if (matrix[rowShoot][colShoot] === "D") {
                matrix[rowShoot][colShoot] = '-';
            } else if (matrix[rowShoot][colShoot][0] === "C") {
                Cuki--;
                console.log('Tank ' + matrix[rowShoot][colShoot][1] + ' is gg');
                if (Cuki === 0) {
                    console.log('Cuki is gg');
                }
                matrix[rowShoot][colShoot] = '-';
            } else if (matrix[rowShoot][colShoot][0] === "K") {
                Kon--;
                console.log('Tank ' + matrix[rowShoot][colShoot][1] + ' is gg');
                if (Kon === 0) {
                    console.log('Koceto is gg');
                }
                matrix[rowShoot][colShoot] = '-';
            }
        }

    }
}

solve([
    '10 5',
    '1 0;1 1;1 2;1 3;1 4;3 1;3 3;4 0;4 2;4 4',
    '43',
    'mv 6 5 r',
    'mv 0 6 d',
    'x 0 d',
    'x 0 d',
    'x 6 u',
    'x 6 u',
    'x 6 u',
    'x 6 u',
    'x 6 u',
    'x 7 u',
    'x 7 u',
    'x 7 u',
    'x 7 u',
    'x 7 u',
    'x 3 d',
    'x 3 d',
    'x 3 d',
    'x 3 d',
    'x 3 d',
    'x 4 u',
    'x 4 u',
    'x 4 u',
    'x 4 u',
    'x 4 u',
    'x 0 r',
    'mv 0 6 d',
    'mv 0 9 r',
    'x 0 d',
    'mv 0 1 l',
    'x 0 d',
    'mv 0 1 l',
    'x 0 d',
    'mv 0 1 l',
    'x 0 d',
    'mv 0 1 l',
    'x 0 d',
    'mv 0 1 l',
    'x 0 d',
    'mv 0 1 l',
    'x 0 d',
    'mv 0 1 l',
    'x 0 d',
    'mv 0 1 l',
    'x 0 d'
]);