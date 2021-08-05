import { Component, OnInit } from '@angular/core';
import { Content_model } from 'src/app/@Models/Content_model';
import { ParserService } from 'src/app/@Services/parser.service';
import { IMultiSelectOption, IMultiSelectSettings, IMultiSelectTexts } from 'ngx-bootstrap-multiselect';
import { SearchService } from 'src/app/@Services/search.service';
import { Router } from '@angular/router';
import { multiselect_model } from 'src/app/@Models/MultiSelect_model';

@Component({
  selector: 'app-home-one',
  templateUrl: './home-one.component.html',
  styleUrls: ['./home-one.component.scss']
})

export class HomeOneComponent implements OnInit {

  content: Array<Content_model>;

  to_print: Array<Content_model>;

  gridColumns = 4;

  optionsModel: number[] = [2, 3, 4, 5, 6];

  // Settings configuration
  mySettings: IMultiSelectSettings = multiselect_model.Settings;

  //options config
  myOptions: IMultiSelectOption[] = multiselect_model.Options;

  // Text configuration
  myTexts: IMultiSelectTexts = multiselect_model.Texts;

  constructor(private router: Router, private parser: ParserService, private search: SearchService) { }

  ngOnInit(): void {
    this.content = this.parser.parse();
    this.to_print = this.content;
  }

    /**
   * Triggered on searhbox input change
   *
   * @param event - The $event
   * 
   * @landing
   */
  onChangeEvent(event: any) {

    let options = this.optionsModel;
    let filters = [options.includes(2), options.includes(5), options.includes(6), options.includes(4)];
    let input = event.target.value;
    this.to_print = this.search.search(input, filters, this.content);

  }
}
