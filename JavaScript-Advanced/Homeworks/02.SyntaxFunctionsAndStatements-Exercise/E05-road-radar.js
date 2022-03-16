function solve(speed, area) {

    let output = "";
    switch (area) {
        case 'motorway':
            if (speed > 130) {
                
                output += `The speed is ${speed - 130} km/h faster than the allowed speed of 130 - `;

                if (speed - 130 > 40) {
                    output += 'reckless driving';
                    break;
                } if (speed - 130 <= 20) {
                    output += 'speeding';
                } else {
                    output += 'excessive speeding';
                }
            } else {
                console.log(`Driving ${speed} km/h in a 130 zone`);
            }
            break;
        case 'interstate':
            if (speed > 90) {
                output += `The speed is ${speed - 90} km/h faster than the allowed speed of 90 - `;

                if (speed - 90 > 40) {
                    output += 'reckless driving';
                    break;
                } if (speed - 90 <= 20) {
                    output += 'speeding';
                } else {
                    output += 'excessive speeding';
                }
            } else {
                console.log(`Driving ${speed} km/h in a 90 zone`);
            }
            break;
        case 'city':
            if (speed > 50) {
                output += `The speed is ${speed - 50} km/h faster than the allowed speed of 50 - `;

                if (speed - 50 > 40) {
                    output += 'reckless driving';
                    break;
                } if (speed - 50 <= 20) {
                    output += 'speeding';
                } else {
                    output += 'excessive speeding';
                }
            } else {
                console.log(`Driving ${speed} km/h in a 50 zone`);
            }
            break;
        case 'residential':
            if (speed > 20) {
                output += `The speed is ${speed - 20} km/h faster than the allowed speed of 20 - `;

                if (speed - 20 > 40) {
                    output += 'reckless driving';
                    break;
                } if (speed - 20 <= 20) {
                    output += 'speeding';
                } else {
                    output += 'excessive speeding';
                }

            } else {
                console.log(`Driving ${speed} km/h in a 20 zone`);
            }
            break;
    }

    console.log(output);
}



solve(60, 'residential')

