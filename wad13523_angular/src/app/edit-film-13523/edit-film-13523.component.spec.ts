import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditFilm13523Component } from './edit-film-13523.component';

describe('EditFilm13523Component', () => {
  let component: EditFilm13523Component;
  let fixture: ComponentFixture<EditFilm13523Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [EditFilm13523Component]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(EditFilm13523Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
