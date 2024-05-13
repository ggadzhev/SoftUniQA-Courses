let names = ['Georgi', 'Emo', 'Galin', 'Mario', 'BatMacho'];  //declare array
console.log(names);
console.log(names.length);  // get the lenght of the array

console.log(names[3]);  // get 3rd element in array

//names.length = 6;
//console.log(names.length);
firstName = names[0];  // get first element in array
lastname = names[names.length - 1];  //get last element in array
console.log(firstName);
console.log(lastname);

let [] = names;
console.log(names);
// array de-structuring
let[fName, lName] = names;
console.log(fName, lName);


// pop method - call metod pop on array and delete last element and reduce the array lenght by 1

let lastArrayName = names.pop();  //mutating method for arrays. Last element from array is taken and assigned to the variable, but array will be reduced 
console.log(lastArrayName);
console.log(names.length);   // names array originally was 5 elements, now is 4 after using POP method

//push method - call on method to add new elements

names.push('Mimi');
console.log(names);   // added new name + increasing the size of array + 1 

//Shift method - call on method to remove first element in array and reduce the size by 1

let newNames = names.shift();   
console.log(newNames);
console.log(names);

//unshift method - adding new element infront of the first and increasing the size of the array by 1

names.unshift('Gabi');
console.log(names);

// reverse method - arranges the elements of an array from last to first (reverses elements)

names.reverse();
console.log(names);

// join - non-mutating method - splits the elemenets with a char between them 

let names1 = names.join(' - ');
console.log(names1);

// slice - non-mutating method - takes an element from start until end given element and removes the ones after the end 

let names2 = names.slice(0, 3);  // takes the 0, 1 and 2nd elements
console.log(names2);

// includes - method (true/false) - checks if an element is present in an array

let names3 = names;

if (names3.includes('Bibi')) {
    console.log('No such name');
}

// forEach

names.forEach(name => console.log(name));  // will console log every name in the names array

// MAP

let someName = names.map(names => names.toLocaleLowerCase()); // takes all elements and changes the names characters to lower case
console.log(someName);

//find

let nameWithG = names.find(name => name.startsWith('G'));
console.log(nameWithG);

//Filter

let nameWithT = names.filter(name => name.startsWith('T'));
console.log(nameWithT);


