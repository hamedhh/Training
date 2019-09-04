interface   person{
    firstName:string;
    lastName:string;
} 
class MyClasss{
    
}

function logPerson(person: person)
{
    return "Hi ,"+person.firstName +"  " + person.lastName;
}
let user ={firstName:'Hamed',lastName:'HH'};
document.body.innerHTML=logPerson(user);