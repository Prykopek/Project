import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';

import { AppComponent } from './app.component';
import { ValueComponent } from './value/value.component'; // dodane po stworzeniu componentu value

@NgModule({
   declarations: [
      AppComponent,
      ValueComponent // dodane po stworzeniu componentu value
   ],
   imports: [
      BrowserModule,
      HttpClientModule// Client module
   ],
   providers: [],
   // bootstrapowanie angular components
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
