import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Navigation13523Component } from './navigation13523.component';

describe('Navigation13523Component', () => {
  let component: Navigation13523Component;
  let fixture: ComponentFixture<Navigation13523Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Navigation13523Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(Navigation13523Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
