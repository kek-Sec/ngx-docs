import { Component, OnInit } from '@angular/core';
import { Content_model } from 'src/app/@Models/Content_model';
import { ParserService } from 'src/app/@Services/parser.service';
import {
  IMultiSelectOption,
  IMultiSelectSettings,
  IMultiSelectTexts,
} from 'ngx-bootstrap-multiselect';
import { SearchService } from 'src/app/@Services/search.service';
import { multiselect_model } from 'src/app/@Models/MultiSelect_model';
import { SettingsParserService } from 'src/app/@Services/settings-parser.service';
import { Settings_model } from 'src/app/@Models/Settings_model';

@Component({
  selector: 'app-home-one',
  templateUrl: './home-one.component.html',
  styleUrls: ['./home-one.component.scss'],
})
export class HomeOneComponent implements OnInit {
  _settings_item: Array<Settings_model>; //should be changed to object not array
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

  //used for pagination
  page: number = 1;

  constructor(
    private parser: ParserService,
    private search: SearchService,
    private settings: SettingsParserService
  ) {}

  ngOnInit(): void {
    //parse input.json
    this.content = this.parser.parse();
    //set to_print collection
    this.to_print = this.content;
    //parse settings.json
    this._settings_item = this.settings.parse();
    //set grid columns from settings file
    this.gridColumns = this._settings_item[0]
      .preview_number_of_columns as number;
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
    let filters = [
      options.includes(2),
      options.includes(5),
      options.includes(6),
      options.includes(4),
    ];
    let input = event.target.value;
    this.to_print = this.search.search(input, filters, this.content);
  }
}
