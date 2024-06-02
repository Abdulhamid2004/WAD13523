import { Injectable, inject } from '@angular/core';
import { Film13523 } from './film13523';
import { Review13523 } from './review13523';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class Filmservice13523Service {
  httpClient = inject(HttpClient);
  constructor() { }

  getAllFilms(){
    return this.httpClient.get<Film13523[]>("http://localhost:5110/api/Film13523")
  };

  getFilmByID(id:number){
    return this.httpClient.get<Film13523>("http://localhost:5110/api/Film13523/"+id);
  };
  editFilm(id:number, item:Film13523){
    return this.httpClient.put("http://localhost:5110/api/Film13523/"+id, item);  
  };
  deleteFilm(id:number){
    return this.httpClient.delete("http://localhost:5110/api/Film13523/"+id);
  };
  createFilm(item:Film13523){
    return this.httpClient.post<Film13523>("http://localhost:5110/api/Film13523", item);
  };
  getAllReviews(){
    return this.httpClient.get("http://localhost:5110/api/Review13523")
  };
  getReviewById(id:number){
    return this.httpClient.get<Review13523>("http://localhost:5110/api/Review13523/"+id);
  };
  editReview(id:number, item:Review13523){
    return this.httpClient.put("http://localhost:5110/api/Review13523/"+id, item);  
  };
  deleteReview(id:number){
    return this.httpClient.delete("http://localhost:5110/api/Review13523/"+id);
  };
  createReview(item:Review13523){
    return this.httpClient.post<Review13523>("http://localhost:5110/api/Review13523", item);
  };
}
