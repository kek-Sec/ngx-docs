import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailedPageThreeComponent } from './detailed-page-three.component';

describe('DetailedPageThreeComponent', () => {
  let component: DetailedPageThreeComponent;
  let fixture: ComponentFixture<DetailedPageThreeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailedPageThreeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetailedPageThreeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
