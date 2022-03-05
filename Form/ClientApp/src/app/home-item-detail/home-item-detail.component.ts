import { FormService } from "./../services/form.service";
import { FormDto } from "./../models/formDto.model";
import { Component, OnInit } from "@angular/core";
import { ActivatedRoute } from "@angular/router";

@Component({
  selector: "app-home-item-detail",
  templateUrl: "./home-item-detail.component.html",
  styleUrls: ["./home-item-detail.component.css"],
})
export class HomeItemDetailComponent implements OnInit {
  form: FormDto;

  constructor(
    private route: ActivatedRoute,
    private FormService: FormService
  ) {}

  ngOnInit() {
    this.FormService.getFormId(this.route.snapshot.params["id"]).subscribe({
      next: (data) => {
        this.form = data;
      },
    });
  }
}
