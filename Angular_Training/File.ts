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
// var listperson:string[]=["Hamed","Iman"];
// console.log(listperson);

// var listGen:Array<string> =["Hamed","Iman"]; 

// //لیثتی که یک استرینگ و یک عدد میگیرد به عنوان یک آینم
// var tuple:[string,number];
// tuple=["hamed",27];

// enum color{
//     green=5, //پیش فرض از صفر شروع میشود
//     red=6
// }

// console.log(color[5])
// console.log(color.green)

// var harchi:any;//هرچیزی میشود در این تاایپ ریخت

// harchi="asd",
// harchi=123;

// var listHarchi:any[]=["hamed",21,true]


//----03--------

// let Name:string='Hamed';//..بجای استفاده از وّرررر در جاوااسکریپت


//----04--------
//نوع خروجی تابع را هم میتوان نوشت
function sum(a:number,b:number):number
{
    return a+b;
}

console.log(sum(5,8))
// let : اگر استفاده شود دیگر نمیتوان از آن متغییر در بلوک مورد نظر تعبریف کرد

let fullName= function(firstName:string,lastName:string):string{
    return firstName + " " + lastName; 
}

console.log(fullName("hamed","halvaei"));

//param : در تایپ اسکرریپت به صورت زیر تعریف میشوئ

function ShowName(name:string,...names:string[]):string
{
    console.log(names);
    return name + " : ... "+names.join(" ");
}

console.log(ShowName("hamed","mamad","ali","hasan"))