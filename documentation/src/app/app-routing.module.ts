import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AlbumPageComponent } from './@core/album-page/album-page.component';
import { DetailedPageOneComponent } from './@core/detailed-page-one/detailed-page-one.component';
import { DetailedPageThreeComponent } from './@core/detailed-page-three/detailed-page-three.component';
import { DetailedPageTwoComponent } from './@core/detailed-page-two/detailed-page-two.component';
import { HomeTwoComponent } from './@landings/home-two/home-two.component';

const routes: Routes = [
  { path: '', component: HomeTwoComponent },
  { path: 'view/undefined', redirectTo: '', pathMatch: 'full' },
  { path: 'view/:id', component: DetailedPageOneComponent },
  { path: 'album/undefined', redirectTo: '', pathMatch: 'full' },
  { path: 'album/:id', component: AlbumPageComponent },

  { path: '**', component: HomeTwoComponent }, // This line will remain down from the whole pages component list
];
@NgModule({
  imports: [RouterModule.forRoot(routes, { relativeLinkResolution: 'legacy' })],
  exports: [RouterModule],
})
export class AppRoutingModule { }
