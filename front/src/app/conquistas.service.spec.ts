import { TestBed } from '@angular/core/testing';

import { ConquistasService } from './conquistas.service';

describe('ConquistasService', () => {
  let service: ConquistasService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ConquistasService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
