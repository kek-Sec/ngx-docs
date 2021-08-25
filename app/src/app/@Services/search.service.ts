import { Injectable } from '@angular/core';
import { Content_model } from '../@Models/Content_model';
import { ToastrService } from 'ngx-toastr';

@Injectable({
  providedIn: 'root',
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

  constructor(private toastr: ToastrService) {}

  /**
   * Returns the average of two numbers.
   *
   * @param text - The text to search for
   * @param filters - Boolean array according to the aformentioned syntax
   * @param dataset - Array of Content_model objects containing the objects to search
   *
   * @returns Array including all the matching Content_model objects
   *
   * @todo Fix search by tags.
   *
   * @service
   */
  search(
    text: string,
    filters: boolean[],
    dataset: Array<Content_model>
  ): Array<Content_model> {
    let to_return = Array<Content_model>();

    for (let i = 0; i < dataset.length; i++) {
      let txt = text.toUpperCase();

      //By  title
      if (dataset[i].Title.toUpperCase().includes(txt) && filters[0]) {
        to_return.push(dataset[i]);
        continue;
      }

      //By id
      if (i.toString() === txt && filters[1]) {
        to_return.push(dataset[i]);
        continue;
      }

      //By description
      let desc = dataset[i].Description as string;
      if (desc.toUpperCase().includes(txt) && filters[2]) {
        to_return.push(dataset[i]);
        continue;
      }

      //By content
      let items = dataset[i].items as string[];
      let content = items.join(' ').toUpperCase();

      if (content.includes(txt) && filters[3]) {
        to_return.push(dataset[i]);
        continue;
      }

      //By tags -- needs re work
      if (dataset[i].tags == undefined) {
        continue;
      }
      let tags = dataset[i].tags?.join(' ').toUpperCase();
      if (tags?.includes(txt) && filters[4]) {
        to_return.push(dataset[i]);
        continue;
      }
    }

    //show success toast
    this.toastr.success('', 'Fetched [' + to_return.length + ']', {
      positionClass: 'toast-bottom-left',
      progressBar: true,
      timeOut: 1500,
    });
    return to_return;
  }
}
