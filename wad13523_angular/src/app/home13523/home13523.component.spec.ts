import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Home13523Component } from './home13523.component';

describe('Home13523Component', () => {
  let component: Home13523Component;
  let fixture: ComponentFixture<Home13523Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Home13523Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(Home13523Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
