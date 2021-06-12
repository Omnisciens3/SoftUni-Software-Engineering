function solve(a, b, c) {
    let sumLength = a.length + b.length + c.length;
    let averageLength = Math.floor(sumLength / 3);

    console.log(sumLength);
    console.log(averageLength);
}

solve('chocolate', 'ice cream', 'cake');