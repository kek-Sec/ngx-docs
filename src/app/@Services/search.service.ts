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

  /**
   * Returns the average of two numbers.
   *
   * @remarks
   * This method is part of the {@link core-library#Statistics | Statistics subsystem}.
   *
   * @param text - The text to search for
   * @param filters - Boolean array according to the aformentioned syntax
   * @param dataset - Array of Content_model objects containing the objects to search
   * 
   * @returns Array including all the matching Content_model objects
   *
   * @service
   */
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
      if(i.toString() === (txt) && filters[1])
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
      if(dataset[i].tags == undefined ) {continue;}
      let tags = dataset[i].tags?.join(" ").toUpperCase();
      if(tags?.includes(txt) && filters[4])
      {
        to_return.push(dataset[i]);
        continue;
      }
   }
    
    return to_return;
  }

}
