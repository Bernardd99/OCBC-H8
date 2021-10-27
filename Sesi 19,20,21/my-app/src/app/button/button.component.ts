import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent implements OnInit {
  @Input() name = '';
  @Input() message = '';

  @Output() clickHandler = new EventEmitter();

  // buat 1 function untuk handle event
  onButtonClick() {
    this.clickHandler.emit();
    // this.message = 'Halo';
  }

  constructor() { }

  ngOnInit(): void {
  }

}
