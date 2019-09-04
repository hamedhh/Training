//----01----
// interface   person{
//     firstName:string;
//     lastName:string;
// } 
// class MyClasss{
// }
// function logPerson(person: person)
// {
//     return "Hi ,"+person.firstName +"  " + person.lastName;
// }
// let user ={firstName:'Hamed',lastName:'HH'};
// document.body.innerHTML=logPerson(user);
//----02-----
var listperson = ["Hamed", "Iman"];
console.log(listperson);
var listGen = ["Hamed", "Iman"];
//لیثتی که یک استرینگ و یک عدد میگیرد به عنوان یک آینم
var tuple;
tuple = ["hamed", 27];
var color;
(function (color) {
    color[color["green"] = 5] = "green";
    color[color["red"] = 6] = "red";
})(color || (color = {}));
console.log(color[5]);
console.log(color.green);
var harchi; //هرچیزی میشود در این تاایپ ریخت
harchi = "asd",
    harchi = 123;
var listHarchi = ["hamed", 21, true];
