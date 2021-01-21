import { Injectable } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router";
import { UserService } from "../services/user/user.service";

@Injectable({
  providedIn: 'root'
})
export class RoutesGuard implements CanActivate{

  constructor(private router: Router, private userService: UserService) {
    }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean {
      if (this.userService.authenticated_user()) {
        return true;
      }
      this.router.navigate(['/sign-in'], { queryParams: { returnUrl: state.url } });
      //se user autenticado
        return false;
    }

  

}
