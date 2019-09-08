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
// functions
// //نوع خروجی تابع را هم میتوان نوشت
// function sum(a:number,b:number):number
// {
//     return a+b;
// }
// console.log(sum(5,8))
// // let : اگر استفاده شود دیگر نمیتوان از آن متغییر در بلوک مورد نظر تعبریف کرد
// let fullName= function(firstName:string,lastName:string):string{
//     return firstName + " " + lastName; 
// }
// console.log(fullName("hamed","halvaei"));
// //param : در تایپ اسکرریپت به صورت زیر تعریف میشوئ
// function ShowName(name:string,...names:string[]):string
// {
//     console.log(names);
//     return name + " : ... "+names.join(" ");
// }
// console.log(ShowName("hamed","mamad","ali","hasan"))
//----05--------
// calsses-- Interface
// interface IUser{
//     name:string;
//     family:string;
//     email:string;
//     phone?:string
// }
// let usreImpelement1:IUser={
//     email:"d@k.com",
//     family:"halvaei",
//     name:"hamed"
// }
// let usreImpelement2:IUser={
//     email:"d@k.com",
//     family:"halvaei",
//     name:"hamed"
// }
// function Rejister(user:IUser)
// {
//     console.log(user);
// }
// //----------------polymorphisem....----.!
// Rejister(usreImpelement1)
// Rejister(usreImpelement2)
// //------------Interface Immpelement--------------------
// interface IUserManger{
//     Rejisre:(user:IUser)=>boolean;
//     Login:(userName:string,passWord:string)=>void;
// }
// class UserManager implements IUserManger
// {
//     Rejisre(inpuUser:IUser){
//         return true;
//     }
//     Login(userName:string,passWord:string)
//     {
//     }
// }
// class  Person {
//     name:string;
//     family:string;
//     email:string;
//     constructor(){
//         this.name="";
//         this.family="";
//         this.email="";
//     }
// }
// // در حکم سازنده کلاس عمل می کند!.م
// let p1 = new Person();
// p1.name="hamed";
// p1.family="halavei";
// p1.email="H@h.com";
// console.log(p1);
// console.log(p1.name+" " +p1.family)
//----06--------
// // Generic
// //فانکشن با تایپ آنانیموووووس
// // function PrintInfo(data:any):any
// // {
// //     console.log(data);
// // }
// // PrintInfo([1,2,3,4,5,6,7,8,9]);
// //generic funcftions----------
// function MyType<T>(value:T):T 
// {
//     return value;
// }
// // console.log(MyType(123))
// // console.log(MyType('salam'))
// // console.log(MyType<string>('typeString'))
// function arrayType<T>(data:T[]):T[]
// {
//     return data;
// }
// console.log(arrayType<string>(['a','b','c']))
//----07--------
// Module


//saasasd