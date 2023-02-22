import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './Error/not-found/not-found.component';
import { AccountComponent } from './Forms/account/account.component';
import { CreateAccountComponent } from './Forms/create-account/create-account.component';
import { LoginComponent } from './Forms/login/login.component';
import { HomeComponent } from './Main/home/home.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent},
  { path: 'account', component: AccountComponent},
  { path: 'create-account', component: CreateAccountComponent},
  { path: 'login', component: LoginComponent},
  // redirect to `home-component`
  { path: '',   redirectTo: '/home', pathMatch: 'full' },
  // if all else fails, go to error page (not found)
  { path: '**', component: NotFoundComponent }
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
