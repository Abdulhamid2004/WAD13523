import { Component, inject } from '@angular/core';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatIconModule} from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { Router } from '@angular/router';
import { MatMenu, MatMenuModule } from '@angular/material/menu';

@Component({
  selector: 'app-navigation',
  standalone: true,
  imports: [MatToolbarModule, MatIconModule, MatButtonModule, MatMenuModule, MatIconModule],
  templateUrl: './navigation13523.component.html',
  styleUrl: './navigation13523.component.css'
})
export class Navigation13523Component {
  router =inject(Router)
  AddFilmClicked(){
    this.router.navigateByUrl("addFilm")
  }
  AddReviewClicked(){
    this.router.navigateByUrl("addReview")
  }
  onHomeIconClicked(){
    this.router.navigateByUrl("home")
  }
}
