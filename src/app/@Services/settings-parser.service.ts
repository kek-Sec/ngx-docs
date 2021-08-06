import { Injectable } from '@angular/core';
import inputJson from "src/settings.json";
import {plainToClass} from "class-transformer";
import { Settings_model } from '../@Models/Settings_model';

@Injectable({
  providedIn: 'root'
})
export class SettingsParserService {


  DocJson: any = inputJson;
  content: Array<Settings_model>;

  
  /**
   * Parses the local input.json file
   *
   * .
   *
   * @returns Content_model array 
   *
   * @services
   */
  parse():Array<Settings_model> {
    this.content = plainToClass(Settings_model, this.DocJson as []);
    return this.content;
  }

  

  constructor() { }
}
