import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Navigation13523Component } from './navigation13523/navigation13523.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, Navigation13523Component],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'wad13523_angular';
}
