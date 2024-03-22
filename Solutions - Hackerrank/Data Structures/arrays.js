/*
 * Complete the 'reverseArray' function below.
 *
 * The function is expected to return an INTEGER_ARRAY.
 * The function accepts INTEGER_ARRAY a as parameter.
 */

function reverseArray(a) {
    // Write your code here
    let reverseArr = [];
    
    for(let i = a.length-1; i >= 0; i--){
        reverseArr.push(a[i]);
    }

    // could also do: let reverseArr = a.reverse();
    
    return reverseArr;
}