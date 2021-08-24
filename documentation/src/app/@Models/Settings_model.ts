export class Settings_model {
  preview_show_picture?: boolean = true;
  preview_show_title?: boolean = true;
  preview_show_description?: boolean = true;
  preview_show_text?: boolean = true;
  preview_show_items?: boolean = true;
  preview_show_url?: boolean = false;
  preview_show_album?: boolean = false;
  preview_show_tags?: boolean = false;

  //preview settings
  preview_description_text_length?: number = 15;
  preview_text_length?: number = 15;
  preview_item_text_length?: number = 4;
  preview_items_count?: number = 3;

  //flex layout settings
  preview_number_of_columns?: number = 4;

}
