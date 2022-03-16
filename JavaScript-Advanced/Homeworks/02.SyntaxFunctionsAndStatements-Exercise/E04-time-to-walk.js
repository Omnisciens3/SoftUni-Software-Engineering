function solve(stepsToSchool, footPrintLength, speed){ 

    let distanceInMeters = stepsToSchool * footPrintLength;
    let distanceInKm = (stepsToSchool * footPrintLength) / 1000;
    let timeInMinutes = (distanceInKm / speed) * 60;
    let timeInSeconds = timeInMinutes * 60;
    
    for (let index = 500; index < distanceInMeters; index+=500) {
        timeInSeconds += 60;
    }

    let hour = Math.floor(timeInSeconds / 3600);
    let min = Math.floor(timeInSeconds / 60);
    let sec = Math.round(timeInSeconds - (min * 60));

    let output = `${hour.toString().padStart(2, '0')}:${min.toString().padStart(2, '0')}:${sec.toString().padStart(2, '0')}`;

    console.log(output)
}

solve(4000, 0.60, 5);

