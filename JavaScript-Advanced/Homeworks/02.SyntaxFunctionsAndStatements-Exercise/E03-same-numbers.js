function solve(number){ 

    let numString = String(number);
    let sum = numString.length > 0 ? Number(numString[0]) : 0; //Правим го с тернарен оператор в случай, че ни подадат празен стринг.
    let isTrue = true;

    for (let index = 0; index < numString.length - 1; index++) {
        const element = numString[index];
        const nextElement = numString[index + 1];
        sum += Number(nextElement);

        if (element !== nextElement) {
            isTrue = false;
        }
    }

    console.log(isTrue);
    console.log(sum);
}

solve(1234);