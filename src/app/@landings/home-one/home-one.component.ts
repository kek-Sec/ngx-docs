import { Component, OnInit } from '@angular/core';
import { Content_model } from 'src/app/@Models/Content_model';
import { ParserService } from 'src/app/@Services/parser.service';
import { IMultiSelectOption } from 'ngx-bootstrap-multiselect';

@Component({
  selector: 'app-home-one',
  templateUrl: './home-one.component.html',
  styleUrls: ['./home-one.component.scss']
})
export class HomeOneComponent implements OnInit {

  content: Array<Content_model>;

  gridColumns = 6;

  optionsModel: number[];
  myOptions: IMultiSelectOption[];

  constructor(private parser: ParserService) { }

  ngOnInit(): void {
    this.content = this.parser.parse();

    this.myOptions = [
      { id: 1, name: 'Option 1' },
      { id: 2, name: 'Option 2' },
    ];
  }
  onChange() {
    console.log(this.optionsModel);
  }
}
