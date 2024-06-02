import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddFilm13523Component } from './add-film-13523.component';

describe('AddFilm13523Component', () => {
  let component: AddFilm13523Component;
  let fixture: ComponentFixture<AddFilm13523Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AddFilm13523Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(AddFilm13523Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
