import { Component } from '@angular/core';
// component bootstrapowany w app.module, jest to nasz decorator(javascpript or typescript class but angular features)
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Projekt-SPA';
}
