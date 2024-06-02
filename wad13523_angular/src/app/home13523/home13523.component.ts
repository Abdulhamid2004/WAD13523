import { Component, Input, inject } from '@angular/core';
import { MatCardModule } from '@angular/material/card'; 
import { MatListModule } from '@angular/material/list'; 
import { MatListItem } from '@angular/material/list'; 
import { MatIconModule } from '@angular/material/icon'; 
import { Filmservice13523Service } from '../filmservice-13523.service';
import { Router } from '@angular/router';
import { Film13523 } from '../film13523';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';

@Component({
  selector: 'app-home13523',
  standalone: true,
  imports: [MatButtonModule, MatCardModule, MatListModule, MatListItem, MatIconModule, CommonModule],
  templateUrl: './home13523.component.html',
  styleUrl: './home13523.component.css'
})
export class Home13523Component {
  filmService=inject(Filmservice13523Service); 
  router = inject(Router)
  films:Film13523[]=[]; 
  
  ngOnInit(){
    this.filmService.getAllFilms().subscribe((result)=>{this.films = result}); 
  }
  
  EditClicked(itemID:number){
    this.router.navigateByUrl("/editFilm/"+itemID);
  }

  DetailsClicked(itemID:number){
    this.router.navigateByUrl("/filmDetails/"+itemID);
  }

  DeleteClicked(itemID:number){
    this.filmService.deleteFilm(itemID).subscribe(r=>{
      this.router.navigateByUrl("")
    });
  }

}
