import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SyllebusService {

  constructor(public http: HttpClient) { }

  getAll() {
	  return this.http.get('/api/Syllebus');
  }
}
