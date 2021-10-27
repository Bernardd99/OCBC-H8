import { Component, OnInit } from '@angular/core';
import { Todo } from '../../models/todo';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})

export class TodoListComponent implements OnInit {
  todos: Todo[] = [];

  constructor() { }

  toogleDone (id: number){
    this.todos.map((v, i) =>{
      if (i == id) v.completed = !v.completed;
    })
  }

  deleteTodo(id: number){
    this.todos = this.todos.filter((v, i) => i != id)
  }

  addTodo(todo: Todo){
    this.todos.push(todo);
  }

  ngOnInit(): void {
    this.todos = [
      {
        content: 'First todo',
        completed: false,
        isEdit: false,
      },
      {
        content: 'Second todo',
        completed: false,
        isEdit: false
      }
    ]
  }
}
