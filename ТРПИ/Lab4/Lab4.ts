// Задание 1
interface Person {
    id: number;
    name: string;
    group: number;
}

const array: Person[] = [
    {id: 1, name: 'Vasya', group: 10},
    {id: 2, name: 'Ivan', group: 11},
    {id: 3, name: 'Masha', group: 12},
    {id: 4, name: 'Petya', group: 10},
    {id: 5, name: 'Kira', group: 11},
];

// Задание 2

interface CarsType {
    manufacturer: string;
    model: string;
}

let car: CarsType = { manufacturer: "", model: "" };
car.manufacturer = "manufacturer";
car.model = "model";

// Задание 3

interface ArrayCarsType {
    cars: CarsType[];
}

const car1: CarsType = { manufacturer: "", model: "" };
car1.manufacturer = "manufacturer";
car1.model = "model";

const car2: CarsType = { manufacturer: "", model: "" };
car2.manufacturer = "manufacturer";
car2.model = "model";

const arrayCars: Array<ArrayCarsType> = [{
    cars: [car1, car2]
}];

// Задание 4


type MarkFilterType = 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10;
type DoneType = boolean;
type GroupFilterType = 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12;

type MarkType = {
    subject: string;
    mark: MarkFilterType;
    done: DoneType;
};

type StudentType = {
    id: number;
    name: string;
    group: GroupFilterType;
    marks: Array<MarkType>;
};

type GroupType = {
    students: Array<StudentType>;
    studentsFilter: (group: GroupFilterType) => Array<StudentType>;
    marksFilter: (mark: MarkFilterType) => Array<StudentType>;
    deleteStudent: (id: number) => void;
    mark: MarkFilterType;
    group: GroupFilterType;
};

const group: GroupType = {
    students: [],
    studentsFilter: function (group: GroupFilterType): Array<StudentType> {
        return this.students.filter((student) => student.group === group);
    },
    marksFilter: function (mark: MarkFilterType): Array<StudentType> {
        return this.students.filter((student) =>
            student.marks.some((markItem) => markItem.mark === mark)
        );
    },
    deleteStudent: function (id: number): void {
        const index = this.students.findIndex((student) => student.id === id);
        if (index !== -1) {
            this.students.splice(index, 1);
        }
    },
    mark: 1,
    group: 1,
};

// Пример использования

const student1: StudentType = {
    id: 1,
    name: "Ivan",
    group: 1,
    marks: [
        {
            subject: "Math",
            mark: 7,
            done: true,
        },
        {
            subject: "English",
            mark: 8,
            done: true,
        },
    ],
};

const student2: StudentType = {
    id: 2,
    name: "Petr",
    group: 2,
    marks: [
        {
            subject: "Math",
            mark: 6,
            done: true,
        },
        {
            subject: "English",
            mark: 4,
            done: false,
        },
    ],
};

const student3: StudentType = {
    id: 3,
    name: "Andrey",
    group: 2,
    marks: [
        {
            subject: "Math",
            mark: 7,
            done: true,
        },
        {
            subject: "PE",
            mark: 9,
            done: true,
        },
    ],
};

group.students.push(student1);
group.students.push(student2);
group.students.push(student3);

const studentsFromSecondGroup = group.studentsFilter(2);
console.log("Студенты из второй группы");
console.log(studentsFromSecondGroup);
const studentsWithMarkSeven = group.marksFilter(7);
console.log("Студенты c оценкой 7 ");
console.log(studentsWithMarkSeven);
group.deleteStudent(1);
console.log("Студенты после удаления первого студента");
console.log(group.students);