import { FormService } from "./../services/form.service";
import { Question } from "./../models/question.model";
import { QuetionService } from "./../services/question.service";
import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";

@Component({
  selector: "app-add-form",
  templateUrl: "./add-form.component.html",
  styleUrls: ["./add-form.component.css"],
})
export class AddFormComponent implements OnInit {
  questions: Question[];
  form: {
    questionId: string;
    answer: string;
    person: any;
  };

  constructor(
    private quetionService: QuetionService,
    private formService: FormService,
    private router: Router
  ) {
    this.questions = [];
    this.form = {
      questionId: "",
      answer: "",
      person: {},
    };
  }

  ngOnInit() {
    this.quetionService.getQuestion().subscribe({
      next: (data) => (this.questions = data),
    });
  }

  public addNewForm(): void {
    this.formService.createForm(this.form).subscribe({
      next: (data) => {
        this.router.navigate(['']);
      },
    });
  }
}
