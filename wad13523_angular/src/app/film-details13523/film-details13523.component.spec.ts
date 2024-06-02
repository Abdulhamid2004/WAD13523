import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FilmDetails13523Component } from './film-details13523.component';

describe('FilmDetails13523Component', () => {
  let component: FilmDetails13523Component;
  let fixture: ComponentFixture<FilmDetails13523Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FilmDetails13523Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(FilmDetails13523Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
