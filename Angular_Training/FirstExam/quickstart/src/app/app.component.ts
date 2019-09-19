import { Component } from '@angular/core';

@Component({
  selector: 'my-app',
  template: `<h1>Hello {{name}}</h1><SampleTag></SampleTag>`,
})
export class AppComponent  { name = 'Hamed!'; }
