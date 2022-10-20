function performOperation(secondInteger, secondDecimal, secondString) {
    const firstInteger = 4;
    const firstDecimal = 4.0;
    const firstString = 'HackerRank ';
    
    // Write code that uses console.log to print the sum of the 'firstInteger' and 'secondInteger' (converted to a Number        type) on a new line.
    secondInteger = +secondInteger;
    console.log(firstInteger + secondInteger);

    // Write code that uses console.log to print the sum of 'firstDecimal' and 'secondDecimal' (converted to a Number            type) on a new line.
    secondDecimal = +secondDecimal;
    console.log(firstDecimal + secondDecimal);

    // Write code that uses console.log to print the concatenation of 'firstString' and 'secondString' on a new line. The        variable 'firstString' must be printed first.
    console.log(firstString + secondString);
}