import { Component } from '@angular/core';
import { EpisodeListComponent } from './components/episode-list/episode-list.component';

@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  imports: [EpisodeListComponent]
})
export class AppComponent {
  title = 'PruebaTecnicaCarsales';
}
