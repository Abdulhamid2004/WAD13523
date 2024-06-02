import { Review13523 } from "./review13523";

export interface Film13523 {
    id: number;
    title: string;
    director: string;
    genre: string;
    releaseYear: number;
    duration: number;
    summary: string;
    reviews?: Review13523[];
  }