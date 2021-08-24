import { Injectable } from '@angular/core';
import inputJson from 'src/input.json';
import { plainToClass } from 'class-transformer';

import { Content_model } from '../@Models/Content_model';

@Injectable({
  providedIn: 'root',
})
export class ParserService {
  DocJson: any = inputJson;
  content: Array<Content_model>;

  /**
   * Parses the local input.json file
   * if it fails create sample data displaying error
   *
   * @returns Content_model array
   *
   * @services
   */
  parse(): Array<Content_model> {
    try {
      this.content = plainToClass(Content_model, this.DocJson as []);
      return this.content;
    } catch (Exception) {
      let error_content: Array<Content_model> = new Array<Content_model>();
      let error_entry: Content_model = new Content_model();
      error_entry.Title = Exception;
      error_entry.Description = 'Input.json contains errors!';
      error_entry.text = 'Please see the documentation at https://github.com/kek-Sec/ngx-docs';
      error_entry.image = 'none';
      error_entry.items = new String[1]();
      error_entry.items[0] = 'https://github.com/kek-Sec/ngx-docs';

      error_content.push(error_entry);

      return error_content;
    }
  }

  constructor() {}
}
