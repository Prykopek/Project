import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  baseURL = 'http://localhost:5000/api/products/';

constructor(private http: HttpClient) { }

addproduct(model: any) {
  return this.http.post(this.baseURL + 'addproduct', model);
}

}
