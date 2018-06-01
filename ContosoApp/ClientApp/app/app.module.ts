import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { PersonListComponent } from './person/personList.component';
import { DataService } from './shared/dataService';
import { AppRoutingModule } from './app-routing/app-routing.module';
import { PersonDetailComponent } from './person-detail/person-detail.component';
@NgModule({
  declarations: [
      AppComponent,
      PersonListComponent,
      PersonDetailComponent
  ],
  imports: [
      BrowserModule,
      HttpClientModule,
      AppRoutingModule
  ],
    providers: [
        DataService
    ],
  bootstrap: [AppComponent]
})
export class AppModule { }
