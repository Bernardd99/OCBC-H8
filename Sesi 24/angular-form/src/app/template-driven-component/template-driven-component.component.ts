import { Component, OnInit } from '@angular/core';
import { Task } from '../task';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-template-driven-component',
  templateUrl: './template-driven-component.component.html',
  styleUrls: ['./template-driven-component.component.css']
})
export class TemplateDrivenComponentComponent implements OnInit {
  tasks: Task[] = [];
  categories = ['School', 'Work', 'Hobby']

  onSubmit(form: NgForm){
    const {taskName, category} = form.value
    this.tasks = [...this.tasks, new Task(taskName, false, category)]
    // this.tasks.push(new Task(taskName, false, category))
    console.log(taskName, category)
    form.reset()
  }

  constructor() { }

  ngOnInit(): void {
  }

}
