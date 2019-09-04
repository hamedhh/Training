var MyClasss = /** @class */ (function () {
    function MyClasss() {
    }
    return MyClasss;
}());
function logPerson(person) {
    return "Hi ," + person.firstName + "  " + person.lastName;
}
var user = { firstName: 'Hamed', lastName: 'HH' };
document.body.innerHTML = logPerson(user);
