import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor(private authService: AuthService) { }

  ngOnInit() {
  }
  login() {
    this.authService.login(this.model).subscribe(next => {
      console.log('Logowanie powiodło się');
    }, error => {
      console.log('Logowanie nie powiodło się');
    });
  }

  loggedIn() {
    const token = localStorage.getItem('token');
    return !!token; // jezeli jest cos w tokenie to zwroci true
  }

  logout() {
    localStorage.removeItem('token');
    console.log('Wylogowano');
  }
}
