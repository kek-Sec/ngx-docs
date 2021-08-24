import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailedPageTwoComponent } from './detailed-page-two.component';

describe('DetailedPageTwoComponent', () => {
  let component: DetailedPageTwoComponent;
  let fixture: ComponentFixture<DetailedPageTwoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailedPageTwoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetailedPageTwoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
