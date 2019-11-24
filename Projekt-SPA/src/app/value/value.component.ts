import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {
  // tworzymy class property który wykorzystujemy ponizej
  values: any;
// create to call our api
  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getValues(); // inicjacja metody
  }
  // metoda pobierająca value, tworzony jest observable, daltego musimy użyć subscribe żeby pobrać jego wnętrze
  getValues() {
    this.http.get('http://localhost:5000/api/values').subscribe(response => {
      this.values = response; // zawiera obiekty z value z api
    }, error => {
      console.log(error); // sparwdzenie czy jest error
    });
  }

}
