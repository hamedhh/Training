import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent }  from './app.component';

import {Sample} from './MyComponents/Sample';

@NgModule({
  imports:      [ BrowserModule ],
  declarations: [ AppComponent ,Sample],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
