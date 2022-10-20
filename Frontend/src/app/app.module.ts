import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatCardModule} from "@angular/material/card";
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

@NgModule({
  declarations: [
    AppComponent,
  ],
    imports: [
        BrowserModule,
        BrowserAnimationsModule,
        MatCardModule,
        FontAwesomeModule
    ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
