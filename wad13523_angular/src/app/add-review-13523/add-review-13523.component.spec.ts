import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddReview13523Component } from './add-review-13523.component';

describe('AddReview13523Component', () => {
  let component: AddReview13523Component;
  let fixture: ComponentFixture<AddReview13523Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AddReview13523Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(AddReview13523Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
