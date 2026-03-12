import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SignalChart } from './signal-chart';

describe('SignalChart', () => {
  let component: SignalChart;
  let fixture: ComponentFixture<SignalChart>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [SignalChart],
    }).compileComponents();

    fixture = TestBed.createComponent(SignalChart);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
