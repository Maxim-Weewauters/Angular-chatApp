import { Component } from '@angular/core';
import { User, UserService } from './Core/Services/user.service';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  userData: User[] = [];

  /**Get the necessary data before the class is created*/
  constructor(
    private userService: UserService){}

  getUsers(){
   this.userService.getUsers().subscribe((result) => {
      this.userData = result;
    });
  }

  addUser(user: User) {
    const user02: User = {
      //backend generates unique identifier for user
      id: 0,
      name: "Wim02",
      username: 'wim02',
      password: "wimpie20000"
     };

    if (!user02) { return; }
    this.userService.addUser(user02 as User)
      .subscribe();
  }
}
