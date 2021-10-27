"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
exports.__esModule = true;
var message = "Hello, FSD OCBC 1";
console.log(message);
var address = 'Kebayoran';
function getProfileTS(name, age) {
    console.log("Hello,  " + name + "!, your age is " + age + " old");
}
// getProfileTS('Budi', 19);
getProfileTS('Budi');
//declare object
// declare type secara langsung
var student = {
    name: 'Budi',
    age: 71,
    score: 100
};
var anotherStudent = {
    name: "Rara",
    age: 20,
    score: 100,
    address: "Jl. pemuda 1234"
};
var employees = [
    {
        name: "Bayu",
        age: 21,
        score: 100
    },
    anotherStudent,
    student
];
//dekalarasi class
var Person = /** @class */ (function () {
    // name: string;
    // private age: number;
    function Person(name, age) {
        this.name = name;
        this.age = age;
        this.name = name;
        this.age = age;
    }
    Object.defineProperty(Person.prototype, "personAge", {
        get: function () {
            return this.age;
        },
        enumerable: false,
        configurable: true
    });
    return Person;
}());
var Student = /** @class */ (function (_super) {
    __extends(Student, _super);
    function Student(name, age, score, firstMentor) {
        var _this = 
        //hilangin error
        //1. pakai super
        _super.call(this, name, age) || this;
        _this.mentors = [];
        // this.name = name;
        // this.age = age;
        _this.score = score;
        _this.mentors.push(firstMentor);
        return _this;
    }
    Student.prototype.changeScore = function (newScore) {
        this.score = newScore;
    };
    Student.prototype.addMentor = function (mentorName) {
        this.mentors.push(mentorName);
    };
    Object.defineProperty(Student.prototype, "studentName", {
        get: function () {
            return this.name;
        },
        enumerable: false,
        configurable: true
    });
    return Student;
}(Person));
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
var riyan = new Student('Riyan', 22, 100, 'Arif');
console.log(riyan);
riyan.changeScore(105);
riyan.addMentor('Eas');
console.log(riyan.studentName);
