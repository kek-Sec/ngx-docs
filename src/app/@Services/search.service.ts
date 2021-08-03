import { Injectable } from '@angular/core';
import { Content_model } from '../@Models/Content_model';

@Injectable({
  providedIn: 'root'
})
export class SearchService {

  dataset = Array<Content_model>();
  
  /*
  * filters[0] -> by title
  * filters[1] -> by id
  * filters[2] -> by description
  * filters[3] -> by content
  * filters[4] -> by tags
  */

  constructor() { }

  search(text:string,filters:boolean[],dataset:Array<Content_model>):Array<Content_model>
  {

   let to_return = Array<Content_model>();

   for(let i=0;i<dataset.length;i++)
   {
      let txt = text.toUpperCase();

      //By  title
      if(dataset[i].Title.toUpperCase().includes(txt) && filters[0])
      {
        to_return.push(dataset[i]);
        continue;
      }

      //By id
      if(i.toString().includes(txt) && filters[1])
      {
        to_return.push(dataset[i]);
        continue;
      }

      //By description
      if(dataset[i].Description.toUpperCase().includes(txt) && filters[2])
      {
        to_return.push(dataset[i]);
        continue;
      }

      //By content
      let content = dataset[i].items.join(" ").toUpperCase();

      if(content.includes(txt) && filters[3])
      {
        to_return.push(dataset[i]);
        continue;
      }

      //By tags
      //to be implemented
   }

    return dataset;
  }

}
