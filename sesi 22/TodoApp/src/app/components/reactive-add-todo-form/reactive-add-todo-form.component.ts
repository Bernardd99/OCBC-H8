import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Todo } from '../../models/todo'
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-reactive-add-todo-form',
  templateUrl: './reactive-add-todo-form.component.html',
  styleUrls: ['./reactive-add-todo-form.component.css']
})
export class ReactiveAddTodoFormComponent implements OnInit {
  @Output() newTodoEvent = new EventEmitter<Todo>();

  // inputTodo: string = "";

  addTodoForm = new FormGroup({
    inputTodo: new FormControl('', [
      Validators.required,
      Validators.minLength(5)
    ])
  })

  isSubmitted = false;

  onSubmitState() {
    if (this.isSubmitted == true) {
      this.isSubmitted = false;
    }
  }

  get inputTodo() {
    return this.addTodoForm.get('inputTodo')
  }

  addTodo() {
    this.isSubmitted = true
    if (this.addTodoForm.value.inputTodo.length > 4) {

      const todo: Todo = {
        content: this.addTodoForm.value.inputTodo,
        completed: false,
        isEdit: false
      }
      this.newTodoEvent.emit(todo)
    }

    // this.inputTodo =="";
  }

  constructor() { }

  ngOnInit(): void {
  }

}
