import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Content_model } from 'src/app/@Models/Content_model';
import { ParserService } from 'src/app/@Services/parser.service';

@Component({
  selector: 'app-detailed-page',
  templateUrl: './detailed-page.component.html',
  styleUrls: ['./detailed-page.component.scss']
})
export class DetailedPageComponent implements OnInit {

  private sub: any;
  selected_entry: Content_model;

  constructor(private route: ActivatedRoute,private parser: ParserService
  ) { }

  ngOnInit(): void {
    this.sub = this.route.params.subscribe((params) => {
      this.selected_entry = this.parser.content[params['id']];
    });
  }

}
