import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router'

import { PersonListComponent } from '../person/personList.component'
import { PersonDetailComponent } from '../person-detail/person-detail.component'

const routes: Routes = [
    { path: '', redirectTo: '/person', pathMatch: 'full' },
    { path: 'person', component: PersonListComponent },
    { path: 'detail/:id', component: PersonDetailComponent }
]


@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]

})
export class AppRoutingModule { }
