import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IUsuario } from 'IUsuario';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class IntegracaoService {

  constructor(private http: HttpClient) { }

  api = "http://localhost:5119"

  getAll(): Observable<IUsuario> {
    return this.http.get<IUsuario>(`${this.api}/ListarAlunos`);
  }
  add(usuario?: IUsuario): Observable<IUsuario> {
    return this.http.post<IUsuario>(`${this.api}/CadastrarAluno`, usuario)
  }

  remove(id?: number){
    return this.http.delete<IUsuario>(`${this.api}/DeletarAluno/${id}`)
  }


}
