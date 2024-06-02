import { CommonModule } from '@angular/common';
import { Component, inject } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { Filmservice13523Service } from '../filmservice-13523.service';
import { Router } from '@angular/router';
import { MatCheckbox } from '@angular/material/checkbox';

@Component({
  selector: 'app-add-review-13523',
  standalone: true,
  imports: [FormsModule, MatFormFieldModule, MatSelectModule, MatInputModule, MatButtonModule, CommonModule, ReactiveFormsModule, MatCheckbox],
  templateUrl: './add-review-13523.component.html',
  styleUrl: './add-review-13523.component.css'
})
export class AddReview13523Component {
filmService = inject(Filmservice13523Service);
router = inject(Router);
film: any;

filmId: number = 0;

newReview: any = {
  id: 0,
  rating: 0, 
  comment: "",
  hasSpoilers: false,
  filmId: 0
}

ngOnInit() {
  this.filmService.getAllFilms().subscribe((result) => {
    this.film = result
  });

};
create() {
  this.newReview.filmId=this.filmId
  this.filmService.createReview(this.newReview).subscribe(result=>{
    this.router.navigateByUrl("home")
  });
};
}
