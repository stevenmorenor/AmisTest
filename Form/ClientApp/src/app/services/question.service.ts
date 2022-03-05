import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Question } from "../models/question.model";

@Injectable({
  providedIn: 'root'
})
export class QuetionService {

  constructor(
    private httpClient: HttpClient,
    @Inject("BASE_URL") private baseUrl: string
  ) {}

  public getQuestion(): Observable<Question[]>{
    return this.httpClient.get<Question[]>(`${this.baseUrl}api/Question`);
  }
}
