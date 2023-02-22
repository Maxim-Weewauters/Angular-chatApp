import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, of, tap } from 'rxjs';
import { User } from '../Models/user';

@Injectable({
  providedIn: 'root'
})

export class UserService {

  private urlString: string = 'https://localhost:7007/api'
  
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(private http: HttpClient) { }

  /** GET users from the server */
  public getUsers(): Observable<User[]> {
    const url = `${this.urlString}/users`;
    return this.http.get<User[]>(url)
    .pipe(
      //Get console log before catch error
      tap(_ => console.log('fetched users')),
      catchError(this.handleError<User[]>('getUsers', []))
    );
  }

  public getUser(id: number): Observable<User>{
    const url = `${this.urlString}/${id}`
    return this.http.get<User>(url)
    .pipe(
        //Get console log before catch error
        tap(_ => console.log('fetched user')),
        catchError(this.handleError<User>('getUser'))
      );
  }

  /** POST: add a new hero to the server */
  public addUser(user: User): Observable<User> {
    const url = `${this.urlString}/user`
    return this.http.post<User>(url, user, this.httpOptions).pipe(
      tap((status: any) => console.log(`added user with status = ${status}`)),
      catchError(this.handleError<User>('addUser'))
    );
  }

  private handleError<T>(operation = 'operation', result?: T){
    return (error: any): Observable<T> => {
      //Provide new error loggin
      console.log(error)
      //Let the app keep running by returning an empty result
      return of(result as T)
    }
  }
}

export { User };
