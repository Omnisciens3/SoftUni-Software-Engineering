function solve(num, arg1, arg2, arg3, arg4, arg5) { 
   
    let number = Number(num);
    number = (applyOperation(number, arg1));
    console.log(number);
    number = (applyOperation(number, arg2));
    console.log(number);
    number = (applyOperation(number, arg3));
    console.log(number);
    number = (applyOperation(number, arg4));
    console.log(number);
    number = (applyOperation(number, arg5));
    console.log(number);

    function applyOperation(num, arg) {
        switch (arg) {
            case 'chop': {
                num /= 2;
                break;
            }
                case 'dice': {

                    num = Math.sqrt(num);
                    break;
                }
                case 'spice': {

                    num += 1;
                    break;
                }
                case 'bake': {

                    num *= 3;
                    break;
                }
                case 'fillet': {

                    num -= num * 0.2;
                    break;
                }
        }

        return num;
    }
}

solve('32', 'chop', 'chop', 'chop', 'chop', 'chop');
