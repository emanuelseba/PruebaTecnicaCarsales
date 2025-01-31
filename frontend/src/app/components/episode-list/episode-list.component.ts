import { Component, signal } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RickAndMortyService, Episodes } from '../../services/rick-and-morty.service';

@Component({
  selector: 'app-episode-list',
  standalone: true,
  templateUrl: './episode-list.component.html',
  imports: [CommonModule],
})
export class EpisodeListComponent {
  episodes = signal<Episodes[]>([]);
  currentPage = signal(1);
  totalPages = signal(1);

  constructor(private apiService: RickAndMortyService) {
    this.loadEpisodes();
  }

  loadEpisodes(page: number = 1) {
    this.apiService.getEpisodes(page).subscribe(response => {
      this.episodes.set(response.results);
      this.currentPage.set(page);
      this.totalPages.set(response.info.pages);
    });
  }

  nextPage() {
    if (this.currentPage() < this.totalPages()) {
      this.loadEpisodes(this.currentPage() + 1);
    }
  }

  prevPage() {
    if (this.currentPage() > 1) {
      this.loadEpisodes(this.currentPage() - 1);
    }
  }
}
