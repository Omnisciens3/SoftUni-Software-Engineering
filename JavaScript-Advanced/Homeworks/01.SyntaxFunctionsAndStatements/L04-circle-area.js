function solve(input) {
    let type = typeof(input);

    if (type === typeof(1)) {
        let circleArea = Math.PI * input ** 2;
        console.log(circleArea.toFixed(2));
    } else {
        console.log(`We can not calculate the circle area, because we receive a ${type}.`);
    }
}

solve(5);