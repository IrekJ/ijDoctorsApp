import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Summary } from '../interfaces/summary';
import { Detail } from '../interfaces/detail';


@Injectable({
  providedIn: 'root'
})
export class DataService {
  doctorsUrl = 'http://localhost:5000/api/doctors/';
  constructor(private http: HttpClient) {  }

  getDoctors(): Observable<Summary[]> {
    return this.http.get<Summary[]>(this.doctorsUrl);
  }

  getDoctor(id: number): Observable<Detail> {
    return this.http.get<Detail>(this.doctorsUrl + id);
  }

}
