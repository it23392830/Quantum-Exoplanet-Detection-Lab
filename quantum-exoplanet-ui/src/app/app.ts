import { Component } from '@angular/core';
import { SignalChartComponent } from './signal-chart/signal-chart';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [SignalChartComponent],
  template: `<app-signal-chart></app-signal-chart>`
})
export class App {}
