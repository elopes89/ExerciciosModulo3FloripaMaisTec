import { TestBed } from '@angular/core/testing';

import { IntegracaoService } from './integracao.service';

describe('IntegracaoService', () => {
  let service: IntegracaoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(IntegracaoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
