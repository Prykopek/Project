import {Routes} from '@angular/router';
import { HomeComponent } from './home/home.component';
import { MealComponent } from './meal/meal.component';
import { DietComponent } from './diet/diet.component';
import { CalculatorComponent } from './calculator/calculator.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
    {path: '', component: HomeComponent},
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            {path: 'meal', component: MealComponent},
            {path: 'diet', component: DietComponent},
            {path: 'calculator', component: CalculatorComponent}
        ]
    },
    {path: '**', redirectTo: '', pathMatch: 'full'},
];
