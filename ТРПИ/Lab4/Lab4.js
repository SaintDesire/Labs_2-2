var array = [
    { id: 1, name: 'Vasya', group: 10 },
    { id: 2, name: 'Ivan', group: 11 },
    { id: 3, name: 'Masha', group: 12 },
    { id: 4, name: 'Petya', group: 10 },
    { id: 5, name: 'Kira', group: 11 },
];
var car = { manufacturer: "", model: "" };
car.manufacturer = "manufacturer";
car.model = "model";
var car1 = { manufacturer: "", model: "" };
car1.manufacturer = "manufacturer";
car1.model = "model";
var car2 = { manufacturer: "", model: "" };
car2.manufacturer = "manufacturer";
car2.model = "model";
var arrayCars = [{
        cars: [car1, car2]
    }];
var group = {
    students: [],
    studentsFilter: function (group) {
        return this.students.filter(function (student) { return student.group === group; });
    },
    marksFilter: function (mark) {
        return this.students.filter(function (student) {
            return student.marks.some(function (markItem) { return markItem.mark === mark; });
        });
    },
    deleteStudent: function (id) {
        var index = this.students.findIndex(function (student) { return student.id === id; });
        if (index !== -1) {
            this.students.splice(index, 1);
        }
    },
    mark: 1,
    group: 1
};
// Пример использования
var student1 = {
    id: 1,
    name: "Ivan",
    group: 1,
    marks: [
        {
            subject: "Math",
            mark: 7,
            done: true
        },
        {
            subject: "English",
            mark: 8,
            done: true
        },
    ]
};
var student2 = {
    id: 2,
    name: "Petr",
    group: 2,
    marks: [
        {
            subject: "Math",
            mark: 6,
            done: true
        },
        {
            subject: "English",
            mark: 4,
            done: false
        },
    ]
};
var student3 = {
    id: 3,
    name: "Andrey",
    group: 2,
    marks: [
        {
            subject: "Math",
            mark: 7,
            done: true
        },
        {
            subject: "PE",
            mark: 9,
            done: true
        },
    ]
};
group.students.push(student1);
group.students.push(student2);
group.students.push(student3);
var studentsFromSecondGroup = group.studentsFilter(2);
console.log("Студенты из второй группы");
console.log(studentsFromSecondGroup);
var studentsWithMarkSeven = group.marksFilter(7);
console.log("Студенты c оценкой 7 ");
console.log(studentsWithMarkSeven);
group.deleteStudent(1);
console.log("Студенты после удаления первого студента");
console.log(group.students);
