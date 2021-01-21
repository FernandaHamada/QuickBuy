import { Component, OnInit } from "@angular/core";
import { User } from "../../model/user";
import { Router, ActivatedRoute } from "@angular/router";
import { UserService } from "../../services/user/user.service";

@Component({
  selector: 'qb-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit{


  public user;
  public returnUrl: string;
  private spinner: boolean;
  public message: string;

  constructor(private router: Router, private activateRoute: ActivatedRoute, private userService: UserService) {
  }

  ngOnInit(): void {
    this.returnUrl = this.activateRoute.snapshot.queryParams['returnUrl'];
    this.user = new User();
  }

  signin() {
    this.spinner = true;
    this.userService.VerifyUser(this.user).subscribe(
      user_json => {
        //var returnUser: User;
        //returnUser = data;
        //sessionStorage.setItem("authenticated-user", "1");
        //sessionStorage.setItem("authenticated-email", returnUser.email);
        this.userService.user = user_json;
        if (this.returnUrl == null) {
          this.router.navigate(['/']);
        } else {
          this.router.navigate([this.returnUrl]);
        }
      },
      error => {
        console.log(error.error);
        this.message = error.error;
      }
    );
    this.spinner = false;
  }
}
