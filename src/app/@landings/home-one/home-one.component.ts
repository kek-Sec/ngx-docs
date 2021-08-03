import { Component, OnInit } from '@angular/core';
import { Content_model } from 'src/app/@Models/Content_model';
import { ParserService } from 'src/app/@Services/parser.service';
import { IMultiSelectOption, IMultiSelectSettings, IMultiSelectTexts } from 'ngx-bootstrap-multiselect';
import { templateJitUrl } from '@angular/compiler';

@Component({
  selector: 'app-home-one',
  templateUrl: './home-one.component.html',
  styleUrls: ['./home-one.component.scss']
})
export class HomeOneComponent implements OnInit {

  content: Array<Content_model>;

  gridColumns = 6;

  optionsModel: number[] = [1,2,3,4,5,6,7,8];

  // Settings configuration
  mySettings: IMultiSelectSettings = {
    enableSearch: false,
    showCheckAll: true,
    fixedTitle: true,
    showUncheckAll: true,
    checkedStyle: 'checkboxes',
    buttonClasses: 'btn btn-default btn-block',
    dynamicTitleMaxItems: 0,
    displayAllSelectedText: false
  };

  //options config
  myOptions: IMultiSelectOption[] = [
    { id: 1, name: 'Car brands', isLabel: true },
    { id: 2, name: 'Volvo', parentId: 1 },
    { id: 3, name: 'Honda', parentId: 1 },
    { id: 4, name: 'BMW', parentId: 1 },
    { id: 5, name: 'Colors', isLabel: true },
    { id: 6, name: 'Blue', parentId: 5 },
    { id: 7, name: 'Red', parentId: 5 },
    { id: 8, name: 'White', parentId: 5 }
];

// Text configuration
myTexts: IMultiSelectTexts = {
  checkAll: 'Check all',
  uncheckAll: 'Uncheck all',
  checked: 'item selected',
  checkedPlural: 'items selected',
  searchPlaceholder: 'Find',
  searchEmptyResult: 'Nothing found...',
  searchNoRenderText: 'Type in search box to see results...',
  defaultTitle: 'Filters',
  allSelected: 'All selected',
};

  constructor(private parser: ParserService) { }

  ngOnInit(): void {
    this.content = this.parser.parse();

    

  }
  onChange() {
    console.log(this.optionsModel);
  }
}
