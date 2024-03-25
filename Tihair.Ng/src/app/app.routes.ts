import { Routes } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { WeekCalendarComponent } from './week-calendar/week-calendar.component';

export const routes: Routes = [
    {path: "week-calendar", component: WeekCalendarComponent},
    {path: "home", component: HomeComponent},
    {path: "", component: HomeComponent}
];
