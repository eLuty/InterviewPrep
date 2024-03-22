'use strict';

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
 * Complete the 'miniMaxSum' function below.
 *
 * The function accepts INTEGER_ARRAY arr as parameter.
 */

function miniMaxSum(arr) {
    // Write your code here
    const sortedArr = arr.sort((a, b) => a - b);
    const minArray = sortedArr.slice(0, arr.length - 1);
    const maxArray = sortedArr.slice(1);
    
    const minSum = minArray.reduce((accumulator, currentVal) => accumulator + currentVal, 0);
    const maxSum = maxArray.reduce((accumulator, currentVal) => accumulator + currentVal, 0);
    
    console.log(minSum + " " + maxSum);
}

function main() {

    const arr = readLine().replace(/\s+$/g, '').split(' ').map(arrTemp => parseInt(arrTemp, 10));

    miniMaxSum(arr);
}
