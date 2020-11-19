import { Component, OnInit } from '@angular/core';
import { MapService } from '../services/map.service';

@Component({
  selector: 'lib-map',
  template: ` <p>map works!</p> `,
  styles: [],
})
export class MapComponent implements OnInit {
  constructor(private service: MapService) {}

  ngOnInit(): void {
    this.service.sample().subscribe(console.log);
  }
}
