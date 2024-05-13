function solve(grade) {
    if (grade >= 5.50) {
        console.log("Excellent");
    } else {
        console.log("Not excellent");
    }
}
solve(5.80);


function grade(grade) {
    console.log(grade >= 5.50 ? 'Excellent' : 'Not excellent');
}
grade(4.40);