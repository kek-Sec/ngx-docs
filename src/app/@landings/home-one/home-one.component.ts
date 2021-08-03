import { Component, OnInit } from '@angular/core';
import { Content_model } from 'src/app/@Models/Content_model';
import { ParserService } from 'src/app/@Services/parser.service';
import { IMultiSelectOption, IMultiSelectSettings, IMultiSelectTexts } from 'ngx-bootstrap-multiselect';

@Component({
  selector: 'app-home-one',
  templateUrl: './home-one.component.html',
  styleUrls: ['./home-one.component.scss']
})
export class HomeOneComponent implements OnInit {

  content: Array<Content_model>;

  gridColumns = 6;

  optionsModel: number[] = [1,2,3,4];

  // Settings configuration
  mySettings: IMultiSelectSettings = {
    enableSearch: false,
    showCheckAll: false,
    fixedTitle: true,
    showUncheckAll: false,
    checkedStyle: 'checkboxes',
    buttonClasses: 'btn btn-default btn-block',
    dynamicTitleMaxItems: 0,
    displayAllSelectedText: false
  };

  //options config
  myOptions: IMultiSelectOption[] = [
    { id: 1, name: 'Search using', isLabel: true },
    { id: 2, name: 'Title', parentId: 1 },
    { id: 3, name: 'Description', parentId: 1 },
    { id: 4, name: 'Tags', parentId: 1 }
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
  //for the search input box
  onChangeEvent(event: any){

    console.log(event.target.value);

  }
}
