import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ClipboardService } from 'ngx-clipboard';
import { ToastrService } from 'ngx-toastr';
import { Content_model } from 'src/app/@Models/Content_model';
import { ParserService } from 'src/app/@Services/parser.service';

@Component({
  selector: 'app-detailed-page-two',
  templateUrl: './detailed-page-two.component.html',
  styleUrls: ['./detailed-page-two.component.scss']
})
export class DetailedPageTwoComponent implements OnInit {

  private sub: any;

  selected_entry: Content_model;
  id: number;
  constructor(
    private route: ActivatedRoute,
    private parser: ParserService,
    private _clipboardService: ClipboardService,
    private toastr: ToastrService
  ) { }


  ngOnInit(): void {
    this.sub = this.route.params.subscribe((params) => {
      this.id = +params['id'];
      this.parser.parse();
      this.selected_entry = this.parser.content[this.id];
      console.log(this.id);
    });
  }

  /**
   * @summary Copy object to clipboard
   *
   * @returns void
   *
   * @component
   */
  copy() {
    this._clipboardService.copy(JSON.stringify(this.selected_entry));
    this.toastr.success('', 'Copied to clipboard', {
      progressBar: true,
      timeOut: 1500,
    });
  }
}
