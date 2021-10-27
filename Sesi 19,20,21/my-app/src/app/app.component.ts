import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'my-app';
  message = 'Halo ini dari parent';
  counter = 0;
  items = ['sepatu', 'sendal', 'tas'];
  message1 = '';

  addCounter(){
    this.counter++;
  }

  subCounter(){
    this.counter--;
  }

  resetCounter(){
    this.counter = 0;
  }

  addItemInParent(newItem: string){
    this.items.push(newItem);
  }

  deleteItemInParent(){
    this.items.pop();
  }

}
