'use strict';

const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.split('\n');

    main();
});

function readLine() {
    return inputString[currentLine++];
}

/*
 * Complete the 'diagonalDifference' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts 2D_INTEGER_ARRAY arr as parameter.
 */

function diagonalDifference(arr) {
    // Write your code here
    let leftToRight = 0;
    let rightToLeft = 0;
    
    let rows = arr.length;
    let cols = arr[0].length;
    
    for(let i = 0; i < Math.min(rows, cols); i++){
        let addValue = arr[i][i];
        leftToRight = addValue + leftToRight;
    }
    
    for(let r = 0, c = cols - 1; r < rows && c >= 0; r++, c--){
        let addValue = arr[r][c];
        rightToLeft = addValue + rightToLeft;
    }
    
    const absDiff = Math.abs(leftToRight - rightToLeft);
    return absDiff;
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine().trim(), 10);

    let arr = Array(n);

    for (let i = 0; i < n; i++) {
        arr[i] = readLine().replace(/\s+$/g, '').split(' ').map(arrTemp => parseInt(arrTemp, 10));
    }

    const result = diagonalDifference(arr);

    ws.write(result + '\n');

    ws.end();
}
