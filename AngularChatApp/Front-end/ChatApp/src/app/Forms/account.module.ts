import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AccountComponent } from './account/account.component';
import { CreateAccountComponent } from './create-account/create-account.component';
import { LoginComponent } from './login/login.component';

@NgModule({
  declarations: [
    CreateAccountComponent,
    LoginComponent,
    AccountComponent,
  ],
  imports: [
    CommonModule,
    RouterModule
  ]
})
export class AccountModule { }
