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
 * Complete the 'plusMinus' function below.
 *
 * The function accepts INTEGER_ARRAY arr as parameter.
 */

function plusMinus(arr) {
    // Write your code here
    const elements = arr.length;
    
    let positives = 0;
    let negatives = 0;
    let zeroes = 0;
    
    for(let i = 0; i < arr.length; i++){
        let value = Math.sign(arr[i]);
        
        if(value > 0)
            positives++;
        else if(value < 0)
            negatives++;
        else
            zeroes++;
    }
    
    console.log((positives / elements).toFixed(6));
    console.log((negatives / elements).toFixed(6));
    console.log((zeroes / elements).toFixed(6));
}

function main() {
    const n = parseInt(readLine().trim(), 10);

    const arr = readLine().replace(/\s+$/g, '').split(' ').map(arrTemp => parseInt(arrTemp, 10));

    plusMinus(arr);
}
