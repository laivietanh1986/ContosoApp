import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { PersonList } from './person/personList.component';
import { DataService } from './shared/dataService';
@NgModule({
  declarations: [
      AppComponent,
      PersonList
  ],
  imports: [
    BrowserModule
  ],
    providers: [
        DataService
    ],
  bootstrap: [AppComponent]
})
export class AppModule { }
