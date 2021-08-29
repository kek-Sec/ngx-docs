import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeOneComponent } from './@landings/home-one/home-one.component';
import { FlexLayoutModule } from '@angular/flex-layout';
import { DetailedPageTwoComponent } from './@core/detailed-page-two/detailed-page-two.component';
import { HomeTwoComponent } from './@landings/home-two/home-two.component';
import { AlbumPageComponent } from './@core/album-page/album-page.component';
import { DetailedPageThreeComponent } from './@core/detailed-page-three/detailed-page-three.component';

//ngx-bootstrap-multiselect
import { NgxBootstrapMultiselectModule } from 'ngx-bootstrap-multiselect';
import { FormsModule } from '@angular/forms';


//ngx-clipboard
import { ClipboardModule } from 'ngx-clipboard';

//ngx-toastr
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';


//carousel
import { CarouselModule } from 'ngx-owl-carousel-o';

//pagination
import { NgxPaginationModule } from 'ngx-pagination';

//font-awesome
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

//highlight-js
import { HighlightModule, HIGHLIGHT_OPTIONS } from 'ngx-highlightjs';


@NgModule({
  declarations: [AppComponent, HomeOneComponent, DetailedPageTwoComponent, HomeTwoComponent, AlbumPageComponent, DetailedPageThreeComponent],
  imports: [
    NgxPaginationModule,
    FormsModule,
    HighlightModule,
    BrowserAnimationsModule, // required animations module
    ToastrModule.forRoot(), // ToastrModule added
    NgxBootstrapMultiselectModule,
    FlexLayoutModule,
    ClipboardModule,
    BrowserModule,
    CarouselModule,
    AppRoutingModule,
    FontAwesomeModule,
  ],
  providers: [
    {
      provide: HIGHLIGHT_OPTIONS,
      useValue: {
        fullLibraryLoader: () => import('highlight.js')
      }
    }
  ],
  bootstrap: [AppComponent],
})
export class AppModule { }
