import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Komponen1Component } from './komponen1.component';

describe('Komponen1Component', () => {
  let component: Komponen1Component;
  let fixture: ComponentFixture<Komponen1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ Komponen1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(Komponen1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
