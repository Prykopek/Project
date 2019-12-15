import { Component, OnInit } from '@angular/core';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {
  sum: number;
  calculate(first: number, second: number) {
   first = first / 100;
   first = first * first;
   this.sum = second / first;
  }



  constructor() { }

  ngOnInit() {

    }
  }


