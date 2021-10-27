import { Component, OnInit, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-addnewitem',
  templateUrl: './addnewitem.component.html',
  styleUrls: ['./addnewitem.component.css']
})
export class AddnewitemComponent implements OnInit {
  @Output() newItemEvent = new EventEmitter<|string>();

  addNewItem(value: string){
    this.newItemEvent.emit(value);
  }

  // deleteItem(){
  //   this.newItemEvent.emit();
  // }

  constructor() { }

  ngOnInit(): void {
  }

}
