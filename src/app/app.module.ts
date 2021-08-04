import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeOneComponent } from './@landings/home-one/home-one.component';
import { FlexLayoutModule } from '@angular/flex-layout';

//ngx-bootstrap-multiselect
import { NgxBootstrapMultiselectModule } from 'ngx-bootstrap-multiselect';
import { FormsModule } from '@angular/forms';
import { DetailedPageComponent } from './@core/detailed-page/detailed-page.component';


@NgModule({
  declarations: [
    AppComponent,
    HomeOneComponent,
    DetailedPageComponent
  ],
  imports: [
    FormsModule,
    NgxBootstrapMultiselectModule,
    FlexLayoutModule,
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
