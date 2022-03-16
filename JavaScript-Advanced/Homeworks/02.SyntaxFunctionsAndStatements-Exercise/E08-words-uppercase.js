function solve(text){ 
    let words = text.split(/\W+/g);

    let filteredWords = [];

    for (const word of words) {
        if (word !== '') {
            filteredWords.push(word);
        }
    }

    // console.log(filteredWords.map(a => a.toUpperCase()));

    
    let string = "";

    filteredWords.forEach(function(element){
        string += element.toUpperCase() + ", ";
    });

    let result = string.substring(0, string.length - 2);
    console.log(result);
}

solve('Hi, how are you?');
