import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeOneComponent } from './@landings/home-one/home-one.component';
import { FlexLayoutModule } from '@angular/flex-layout';

//ngx-bootstrap
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';


@NgModule({
  declarations: [
    AppComponent,
    HomeOneComponent
  ],
  imports: [
    BrowserAnimationsModule,
    BsDropdownModule.forRoot(),
    FlexLayoutModule,
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
