import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { User } from "../../model/user";

@Injectable({
  providedIn: "root"
})
export class UserService {

  private baseURL: string;
  private _user: User;

  set user(user: User) {
    sessionStorage.setItem("authenticated-user", JSON.stringify(user));
    this._user = user;
  }

  get user(): User {
    let user_json = sessionStorage.getItem("authenticated-user");
    this._user = JSON.parse(user_json);
    return this._user;
  }

  public authenticated_user(): boolean {
    return this._user != null && this._user.email != "" && this._user.password != "";
  }

  public clean_session() {
    sessionStorage.setItem("authenticated-user", "");
    this._user = null;
  }

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  public VerifyUser(user: User): Observable<User> {
     // Definindo o tipo de informação no cabeçalho, qual o tipo de dado será trafegado
    const headers = new HttpHeaders().set('content-type', 'application/json');

    var body = {
      email: user.email,
      password: user.password
    }
    //this.baseURL = raiz do site que pode ser ex: http://wwww.quickbuy.com/
    return this.http.post<User>(this.baseURL + "api/user/VerifyUser", body, { headers });
  }
}
