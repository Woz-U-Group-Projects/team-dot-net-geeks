import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ImageLibraryComponent } from './image-library.component';

describe('ImageLibraryComponent', () => {
  let component: ImageLibraryComponent;
  let fixture: ComponentFixture<ImageLibraryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ImageLibraryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ImageLibraryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
