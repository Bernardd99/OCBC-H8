import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-reactive-form-component',
  templateUrl: './reactive-form-component.component.html',
  styleUrls: ['./reactive-form-component.component.css']
})
export class ReactiveFormComponentComponent implements OnInit {
  currentUser:{
    isLogin: boolean;
    username: string,
    password: string
  } = {
    isLogin: false,
    username: '',
    password: '',
  }

  LoginForm = new FormGroup({
    username: new FormControl('',[
      Validators.required,
      Validators.minLength(5),
    ]),
    password: new FormControl('')
  })

  isSubmitted = false

  get username(){
    return this.LoginForm.get('username')
  }

  get password(){
    return this.LoginForm.get('password')
  }

  onLogin(){
    console.log(this.LoginForm);
    this.isSubmitted = true;
    this.currentUser = {
      isLogin: true,
      username: this.LoginForm.value.username,
      password: this.LoginForm.value.password
    }
  }

  onSubmitState(){
    if(this.isSubmitted == true){
      this.isSubmitted = false;
    }
  }
    
  constructor() { }

  ngOnInit(): void {
  }

}
