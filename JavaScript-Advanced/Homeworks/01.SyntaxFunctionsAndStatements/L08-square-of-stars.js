function solve(number) {
    let star = '*';
    let line = '';

    if (number == undefined) {
        for(var i = 0; i < 5; i++) {
            line = line + star + ' ';
        }
        
        for(var i = 0; i < 5; i++) {
            console.log(line);
        }
    } else {
        for(var i = 0; i < number; i++) {
            line = line + star + ' ';
        }
        
        for(var i = 0; i < number; i++) {
            console.log(line);
        }
    }    
}

solve();