import { Component, OnInit } from '@angular/core';
import { Content_model } from 'src/app/@Models/Content_model';
import { ParserService } from 'src/app/@Services/parser.service';
import { BsDropdownConfig } from 'ngx-bootstrap/dropdown';

@Component({
  selector: 'app-home-one',
  templateUrl: './home-one.component.html',
  providers: [{ provide: BsDropdownConfig, useValue: { isAnimated: true, autoClose: true } }],
  styleUrls: ['./home-one.component.scss']
})
export class HomeOneComponent implements OnInit {

  content: Array<Content_model>;
  gridColumns = 6;


  constructor(private parser: ParserService) { }

  ngOnInit(): void {
    this.content = this.parser.parse();
  }

}
