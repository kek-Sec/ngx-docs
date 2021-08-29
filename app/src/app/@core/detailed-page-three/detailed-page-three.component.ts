import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { faCopy } from '@fortawesome/free-solid-svg-icons';
import { ClipboardService } from 'ngx-clipboard';
import { ToastrService } from 'ngx-toastr';
import { Content_model } from 'src/app/@Models/Content_model';
import { Settings_model } from 'src/app/@Models/Settings_model';
import { ParserService } from 'src/app/@Services/parser.service';
import { SettingsParserService } from 'src/app/@Services/settings-parser.service';

@Component({
  selector: 'app-detailed-page-three',
  templateUrl: './detailed-page-three.component.html',
  styleUrls: ['./detailed-page-three.component.scss']
})
export class DetailedPageThreeComponent implements OnInit {
  
  _settings_item: Array<Settings_model>;
  private sub: any;
  selected_entry: Content_model;
  id: number;

  has_code: boolean;
  has_url: boolean;
  has_tags: boolean;
  has_album: boolean;
  has_items: boolean;
  pretty_tags: string;
  faCopy = faCopy;

  constructor(
    private settings:SettingsParserService,
    private route: ActivatedRoute,
    private parser: ParserService,
    private _clipboardService: ClipboardService,
    private toastr: ToastrService
  ) { }

  ngOnInit(): void {

    //parse settings.json
    this._settings_item = this.settings.parse();

    this.sub = this.route.params.subscribe((params) => {
      this.id = +params['id'];
      this.parser.parse();
      this.selected_entry = this.parser.content[this.id];
      this.has_url = this.selected_entry.url != undefined;
      this.has_tags = this.selected_entry.tags != undefined;
      this.has_album = this.selected_entry.album != undefined;
      this.has_code = this.selected_entry.code != undefined;
      this.has_items = this.selected_entry.items != undefined;

      if (this.has_tags) { this.pretty_tags = JSON.stringify(this.selected_entry.tags); }
    });
  }

  /**
   *
   * @summary Copy object to clipboard
   *
   * @returns void
   *
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
