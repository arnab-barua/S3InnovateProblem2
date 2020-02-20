import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomLinkRendererComponent } from './custom-link-renderer.component';

describe('CustomLinkRendererComponent', () => {
  let component: CustomLinkRendererComponent;
  let fixture: ComponentFixture<CustomLinkRendererComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CustomLinkRendererComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CustomLinkRendererComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
