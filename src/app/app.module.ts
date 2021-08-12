import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeOneComponent } from './@landings/home-one/home-one.component';
import { FlexLayoutModule } from '@angular/flex-layout';
import { DetailedPageComponent } from './@core/detailed-page-one/detailed-page.component';
import { DetailedPageTwoComponent } from './@core/detailed-page-two/detailed-page-two.component';
import { HomeTwoComponent } from './@landings/home-two/home-two.component';
import { AlbumPageComponent } from './@core/album-page/album-page.component';

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


@NgModule({
  declarations: [AppComponent, HomeOneComponent, DetailedPageComponent, DetailedPageTwoComponent, HomeTwoComponent, AlbumPageComponent],
  imports: [
    FormsModule,
    BrowserAnimationsModule, // required animations module
    ToastrModule.forRoot(), // ToastrModule added
    NgxBootstrapMultiselectModule,
    FlexLayoutModule,
    ClipboardModule,
    BrowserModule,
    CarouselModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule { }
