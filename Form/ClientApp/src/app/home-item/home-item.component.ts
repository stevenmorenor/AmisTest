import { FormDto } from './../models/formDto.model';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-home-item',
  templateUrl: './home-item.component.html',
  styleUrls: ['./home-item.component.css']
})
export class HomeItemComponent implements OnInit {
  @Input() form: FormDto

  constructor() { }

  ngOnInit() {
  }

}
