import { IRelogio } from './../../../Interface/IRelogio';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LojaService {
relogios: Array<IRelogio> = []
  constructor(private http: HttpClient) { }

getAll(): Observable<IRelogio[]>{
  return this.http.get<IRelogio[]>('http://localhost:3000/relogio');
}

}
