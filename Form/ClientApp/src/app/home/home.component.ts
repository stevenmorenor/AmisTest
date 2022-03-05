import { FormDto } from './../models/formDto.model';
import { FormService } from './../services/form.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  forms: FormDto[];

  constructor(private formService: FormService) {
    this.forms = [];
  }

  ngOnInit(): void {
    this.formService.getForms().subscribe({
      next: data => {
        this.forms = data;
      }
    });
  }
}
