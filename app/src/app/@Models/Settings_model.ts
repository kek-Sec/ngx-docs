export class Settings_model {

  //preview settings
  preview_show_picture?: boolean = true;
  preview_show_title?: boolean = true;
  preview_show_description?: boolean = true;
  preview_show_text?: boolean = true;
  preview_show_code?: boolean = true;
  preview_show_items?: boolean = true;
  preview_show_url?: boolean = false;   //not implemented
  preview_show_album?: boolean = false; //not implemented
  preview_show_tags?: boolean = false;  //not implemented
  preview_description_text_length?: number = 15;
  preview_text_length?: number = 15;
  preview_item_text_length?: number = 4;
  preview_items_count?: number = 3;

  //detailed-page settings
  detailed_show_picture?: boolean = true;
  detailed_show_title?: boolean = true;
  detailed_show_description?: boolean = true;
  detailed_show_text?: boolean = true;
  detailed_show_code?: boolean = true;
  detailed_show_items?: boolean = true;
  detailed_show_url?: boolean = false;  
  detailed_show_album?: boolean = false;
  detailed_show_tags?: boolean = false; 


  //flex layout settings
  preview_number_of_columns?: number = 4;

}
