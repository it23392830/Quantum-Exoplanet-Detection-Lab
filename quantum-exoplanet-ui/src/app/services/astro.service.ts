import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AstroService {

  // Railway backend API
  apiUrl = "https://quantum-exoplanet-detection-lab-production.up.railway.app/api/signal";

  constructor(private http: HttpClient) {}

  getSignal(){
    return this.http.get<any>(this.apiUrl);
  }
}