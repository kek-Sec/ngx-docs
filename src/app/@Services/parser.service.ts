import {Injectable} from "@angular/core";
import inputJson from "src/input.json";
import {plainToClass} from "class-transformer";

import { Content_model } from "../@Models/Content_model";

@Injectable({
  providedIn: 'root'
})
export class ParserService {
  DocJson: any = inputJson;
  content: Array<Content_model>;

  parse():Array<Content_model> {
    this.content = plainToClass(Content_model, this.DocJson as []);
    return this.content;
  }
  constructor() { }

}
