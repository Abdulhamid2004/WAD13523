import { CommonModule } from '@angular/common';
import { Component, inject } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule, MatListItem } from '@angular/material/list';
import { ActivatedRoute, Router } from '@angular/router';
import { Film13523 } from '../film13523';
import { Filmservice13523Service } from '../filmservice-13523.service';

@Component({
  selector: 'app-film-details13523',
  standalone: true,
  imports: [MatButtonModule, MatCardModule, MatListModule, MatListItem, MatIconModule, CommonModule],
  templateUrl: './film-details13523.component.html',
  styleUrl: './film-details13523.component.css'
})
export class FilmDetails13523Component {
  filmService=inject(Filmservice13523Service); 
  router = inject(Router)
  film:Film13523 = {
    id: 0,
    title: "",
    director: "",
    genre: "",
    releaseYear: 0,
    duration: 0,
    summary: "",
    reviews: []
  } 
  
  activatedRoute = inject(ActivatedRoute)
  ngOnInit() {
    this.filmService.getFilmByID(this.activatedRoute.snapshot.params["id"]).subscribe((resultedItem) => {
      this.film = resultedItem
    })}

    editReview(id: number){

    }
    deleteReview(id:number){
      this.filmService.deleteReview(id).subscribe(r=>{
        this.router.navigateByUrl("")
      })
    }
  }
