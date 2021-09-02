import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailedPageOneComponent } from './detailed-page-one.component';

describe('DetailedPageOneComponent', () => {
  let component: DetailedPageOneComponent;
  let fixture: ComponentFixture<DetailedPageOneComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailedPageOneComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetailedPageOneComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
