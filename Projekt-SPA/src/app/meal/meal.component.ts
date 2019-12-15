import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-meal',
  templateUrl: './meal.component.html',
  styleUrls: ['./meal.component.css']
})
export class MealComponent implements OnInit {
  todayDate: Date = new Date();
  listMode = false;

  constructor() { }

  ngOnInit() {
  }

  listToggle() {
    this.listMode = !this.listMode;
  }


}
