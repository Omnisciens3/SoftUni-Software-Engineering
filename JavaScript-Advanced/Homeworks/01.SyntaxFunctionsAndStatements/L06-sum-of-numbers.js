function solve(n, m) {
    let result = 0;
    let intN = Number(n);
    let intM = Number(m);

    for (let i = intN; i <= intM; i++) {
        result += i;
    }
    
    console.log(result);
}

solve('-8', '20');
