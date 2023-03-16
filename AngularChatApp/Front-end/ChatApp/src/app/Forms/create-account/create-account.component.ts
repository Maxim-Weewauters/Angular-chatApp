import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { User } from 'src/app/Core/Services/user.service';

//Custom validator, delete later
function passwordCheck(c: AbstractControl): { [key: string]: boolean} | null{
  if(c.value !== null){
    return {'nameGet': true}
  }
  return null
}


@Component({
  selector: 'app-create-account',
  templateUrl: './create-account.component.html',
  styleUrls: ['./create-account.component.scss']
})
export class CreateAccountComponent implements OnInit {
  user!: User;
  userForm!: FormGroup;

  constructor(private fb: FormBuilder) {}

  ngOnInit() {
    this.userForm = this.fb.group({
      name: ['', [Validators.required, Validators.maxLength(32)]],
      username: ['', Validators.required],
      password: ['', [Validators.required, Validators.minLength(8)]]
    })
  }

  clickButten() {
    // setValue can be used but requires every item
    this.userForm.patchValue({
      name: 'Maxim',
      username: 'maxsken',
      password: 'test'
    })
  }

  save(){}
}
