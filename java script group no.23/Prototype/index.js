



function Student(name , id, mobile_no)
{
    this.name=name;
    this.id=id;
    this.mobile_no=mobile_no;

}
Student.prototype.fullDetail=function()
{
    console.log(`Name ${this.name} ID ${this.id} Mobile ${this.mobile_no}`)
}


function PresentStudent(name, id, mobile_no)
{
    Student.call(this, name, id, mobile_no)
}

function NewStudent(name, id, mobile_no)
{
    Student.call(this, name, id, mobile_no)
}

PresentStudent.prototype=Object.create(Student.prototype)
NewStudent.prototype=Object.create(Student.prototype)

let obj1=new PresentStudent(" Tabrez", 2017, 9852486638)
let obj2= new PresentStudent("aryan", 2018, 8407817299)
let obj3=new PresentStudent("Anas", 2018, 8407817299)
let obj4=new NewStudent("Khalid", 2018, 8407817299)


obj1.fullDetail()
obj2.fullDetail()
obj3.fullDetail()
obj4.fullDetail()
