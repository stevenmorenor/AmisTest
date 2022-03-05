import { FormDto } from "./../models/formDto.model";
import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root",
})
export class FormService {
  constructor(
    private httpClient: HttpClient,
    @Inject("BASE_URL") private baseUrl: string
  ) {}

  public getForms(): Observable<FormDto[]> {
    return this.httpClient.get<FormDto[]>(`${this.baseUrl}api/Form`);
  }

  public createForm(form: any): Observable<void> {
    return this.httpClient.post<void>(`${this.baseUrl}api/Form`, form);
  }
  public getFormId(id: string): Observable<FormDto>{
    return this.httpClient.get<FormDto>(`${this.baseUrl}api/Form/${id}`);
  }
}
