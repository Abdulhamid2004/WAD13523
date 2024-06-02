import { Film13523 } from "./film13523";

export interface Review13523 {
    id: number;
    rating: number; 
    comment: string;
    hasSpoilers: boolean;
    filmId: number;
    film?: Film13523;
  }