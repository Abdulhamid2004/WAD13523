import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { Router } from '@angular/router';
import { Filmservice13523Service } from '../filmservice-13523.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-add-film-13523',
  standalone: true,
  imports: [FormsModule, MatFormFieldModule, MatSelectModule, MatInputModule, MatButtonModule, CommonModule],
  templateUrl: './add-film-13523.component.html',
  styleUrl: './add-film-13523.component.css'
})
export class AddFilm13523Component {
filmService = inject(Filmservice13523Service);
router = inject(Router);

newFilm: any = {
  id: 0,
  title: "",
  director: "",
  genre: "",
  releaseYear: 0,
  duration: 0,
  summary: "",
  reviews: []
}

createFilm() {
  this.filmService.createFilm(this.newFilm).subscribe(result=>{
    alert("New film was added to the storage")
    this.router.navigateByUrl("home")
  });
};
}
