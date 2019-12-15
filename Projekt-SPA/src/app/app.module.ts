import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule} from '@angular/forms';
import { BsDropdownModule } from 'ngx-bootstrap';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { AuthService } from './_services/auth.service';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { ErrorInterceptorProvider } from './_services/error.interceptor';
import { MealComponent } from './meal/meal.component';
import { DietComponent } from './diet/diet.component';
import { CalculatorComponent } from './calculator/calculator.component';
import { appRoutes } from './routes';
import { ListComponent } from './list/list.component';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { NgxPaginationModule } from 'ngx-pagination';
import { AddProductComponent } from './addProduct/addProduct.component';



@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      HomeComponent,
      RegisterComponent,
      MealComponent,
      DietComponent,
      CalculatorComponent,
      ListComponent,
      AddProductComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule,
      Ng2SearchPipeModule,
      NgxPaginationModule,
      BsDropdownModule.forRoot(),
      RouterModule.forRoot(appRoutes)
   ],
   providers: [
      AuthService,
      ErrorInterceptorProvider
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
