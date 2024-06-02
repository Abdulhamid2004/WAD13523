import { CommonModule } from '@angular/common';
import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { ActivatedRoute, Router } from '@angular/router';
import { Filmservice13523Service } from '../filmservice-13523.service';
import { Film13523 } from '../film13523';

@Component({
  selector: 'app-edit-film-13523',
  standalone: true,
  imports: [FormsModule, MatFormFieldModule, MatSelectModule, MatInputModule, MatButtonModule, CommonModule],
  templateUrl: './edit-film-13523.component.html',
  styleUrl: './edit-film-13523.component.css'
})
export class EditFilm13523Component {
  filmService = inject(Filmservice13523Service) 
  activatedRoute = inject(ActivatedRoute);
  router = inject(Router);
  editFilm: Film13523 = {
    id: 0,
    title: "",
    director: "",
    genre: "",
    releaseYear: 0,
    duration: 0,
    summary: "",
    reviews: []
  };

  ngOnInit() {
    this.filmService.getFilmByID(this.activatedRoute.snapshot.params["id"]).subscribe(result => {
      this.editFilm = result
    })
  }

  cancel() {
    this.router.navigateByUrl("home")
  }

  edit() {
    this.filmService.editFilm(this.editFilm.id, this.editFilm).subscribe(res=>{
      alert("Changes applied!")
      this.router.navigateByUrl("home");
    })
  }
}
