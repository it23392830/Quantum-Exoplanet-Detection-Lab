import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AstroService {

  apiUrl = "https://localhost:5001/api/signal";

  constructor(private http: HttpClient) {}

  getSignal(){
    return this.http.get<any>(this.apiUrl);
  }
}