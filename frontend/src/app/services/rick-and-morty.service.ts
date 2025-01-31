import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

type ApiResponse<T> = {
  info: { count: number; pages: number; next: string; prev: string };
  results: T[];
};

export interface Episodes {
  id: number;
  name: string;
  air_date: string;
  episode: string;
}

@Injectable({ providedIn: 'root' })
export class RickAndMortyService {
  private apiUrl = 'http://localhost:5000/api/episodes';

  constructor(private http: HttpClient) {}

  getEpisodes(page: number = 1): Observable<ApiResponse<Episodes>> {
    return this.http.get<ApiResponse<Episodes>>(`${this.apiUrl}/?page=${page}`);
  }
}
