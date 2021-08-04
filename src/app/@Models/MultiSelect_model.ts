import { IMultiSelectOption, IMultiSelectSettings, IMultiSelectTexts } from "ngx-bootstrap-multiselect";

/**
   * Configuration model for ngx-multiselect
   *
   * @remarks
   * This method is part of the {@link https://www.npmjs.com/package/ngx-bootstrap-multiselect}.
   *
   *
   * @model
   */
export class multiselect_model {

    public static Settings: IMultiSelectSettings = {
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
    public static Options: IMultiSelectOption[] = [
        { id: 1, name: 'Search using', isLabel: true },
        { id: 2, name: 'Title', parentId: 1 },
        { id: 3, name: 'Description', parentId: 1 },
        { id: 4, name: 'Tags', parentId: 1 },
        { id: 5, name: 'ID', parentId: 1 },
        { id: 6, name: 'Content', parentId: 1 }
    ];

    // Text configuration
    public static Texts: IMultiSelectTexts = {
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
}