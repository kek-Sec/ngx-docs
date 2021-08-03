import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeOneComponent } from './@landings/home-one/home-one.component';

const routes: Routes = [
  {path: '', component: HomeOneComponent},
  // Here add new pages component

  {path: '**', component: HomeOneComponent} // This line will remain down from the whole pages component list
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
