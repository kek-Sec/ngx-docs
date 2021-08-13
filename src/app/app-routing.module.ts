import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AlbumPageComponent } from './@core/album-page/album-page.component';
import { DetailedPageComponent } from './@core/detailed-page-one/detailed-page.component';
import { DetailedPageThreeComponent } from './@core/detailed-page-three/detailed-page-three.component';
import { DetailedPageTwoComponent } from './@core/detailed-page-two/detailed-page-two.component';
import { HomeOneComponent } from './@landings/home-one/home-one.component';
import { HomeTwoComponent } from './@landings/home-two/home-two.component';

const routes: Routes = [
  { path: '', component: HomeTwoComponent },
  { path: 'view/undefined', redirectTo: '', pathMatch: 'full' },
  { path: 'view/:id', component: DetailedPageThreeComponent },
  { path: 'album/undefined', redirectTo: '', pathMatch: 'full' },
  { path: 'album/:id', component: AlbumPageComponent },

  { path: '**', component: HomeOneComponent }, // This line will remain down from the whole pages component list
];
@NgModule({
  imports: [RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' })],
  exports: [RouterModule],
})
export class AppRoutingModule { }
