function solve(numOne, numTwo){ 

    while (numTwo > 0) {
        let temp = numTwo;
        numTwo = numOne % numTwo;
        numOne = temp;
    }

    return numOne;
}

console.log(solve(2154, 458));

