import { Routes } from '@angular/router';
import { Home13523Component } from './home13523/home13523.component';
import { FilmDetails13523Component } from './film-details13523/film-details13523.component';
import { AddFilm13523Component } from './add-film-13523/add-film-13523.component';
import { AddReview13523Component } from './add-review-13523/add-review-13523.component';
import { EditFilm13523Component } from './edit-film-13523/edit-film-13523.component';

export const routes: Routes = [{
    path: "",
    component: Home13523Component
},
{
    path: "home",
    component: Home13523Component
},
{
    path: "filmDetails/:id",
    component: FilmDetails13523Component
},
{
    path: "editFilm/:id",
    component: EditFilm13523Component
},
{
    path: "addFilm",
    component: AddFilm13523Component
},
{
    path: "addReview",
    component: AddReview13523Component
},
];
