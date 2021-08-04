import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DetailedPageComponent } from './@core/detailed-page/detailed-page.component';
import { HomeOneComponent } from './@landings/home-one/home-one.component';

const routes: Routes = [
  {path: '', component: HomeOneComponent},
  { path: 'view/undefined', redirectTo: '', pathMatch: 'full' },
  { path: 'view/:id', component: DetailedPageComponent },

  {path: '**', component: HomeOneComponent} // This line will remain down from the whole pages component list
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
