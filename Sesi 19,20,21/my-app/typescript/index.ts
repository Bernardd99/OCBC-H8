import { throws } from "assert";

const message: string = "Hello, FSD OCBC 1"

console.log(message)

let address: string = 'Kebayoran'

function getProfileTS(name: string, age?: number) {
    console.log(`Hello,  ${name}!, your age is ${age} old`);
}

// getProfileTS('Budi', 19);
getProfileTS('Budi');

//declare object


// declare type secara langsung
let student: {
    name: string
    age: number | string
    score: number
    address?: string
} = {
    name: 'Budi',
    age: 71,
    score: 100
}

// declare type lewat interface
interface StudentObject {
    name: string
    age: number | string
    score: number
    address?: string
}

let anotherStudent: StudentObject = {
    name: "Rara",
    age: 20,
    score: 100,
    address: "Jl. pemuda 1234"
}

let employees: StudentObject[] = [
    {
        name: "Bayu",
        age: 21,
        score: 100,
    },
    anotherStudent,
    student
]

//dekalarasi class
class Person {
    // name: string;
    // private age: number;

    constructor(protected name: string, private age: number) {
        this.name = name;
        this.age = age;
    }

    get personAge(): number {
        return this.age
    }

    // getAge(){
    //     return this.age;
    // }
}

class Student extends Person {

    score: number;
    mentors: string[] = [];

    constructor(name: string, age: number, score: number, firstMentor: string) {
        //hilangin error
        //1. pakai super
        super(name, age)
        // this.name = name;
        // this.age = age;
        this.score = score;
        this.mentors.push(firstMentor)
    }

    changeScore(newScore: number) {
        this.score = newScore;
    }

    addMentor(mentorName: string) {
        this.mentors.push(mentorName)
    }

    get studentName() {
        return this.name
    }
}

// class Student {
//     name: string;
//     age: number;
//     score: number;
//     mentors: string[] = [];

//     constructor(name: string, age: number, score: number, firstMentor: string) {
//         this.name = name;
//         this.age = age;
//         this.score = score;
//         this.mentors.push(firstMentor)
//     }

//     changeScore (newScore: number) {
//         this.score = newScore;
//     }

//     addMentor (mentorName: string){
//         this.mentors.push(mentorName)
//     }
// }

const riyan = new Student('Riyan', 22, 100, 'Arif');
console.log(riyan)
riyan.changeScore(105);
riyan.addMentor('Eas')
console.log(riyan.studentName)