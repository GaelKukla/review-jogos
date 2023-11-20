import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Jogo } from './Jogo';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class JogosService {
  apiUrl = 'http://localhost:5000/Jogo';
  constructor(private http: HttpClient) { }
  listar(): Observable<Jogo[]> {
    const url = `${this.apiUrl}/listar`;
    return this.http.get<Jogo[]>(url);
  }
  buscar(id: number): Observable<Jogo> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.get<Jogo>(url);
  }
  cadastrar(jogo: Jogo): Observable<any> {
    const url = `${this.apiUrl}/cadastrar`;
    return this.http.post<Jogo>(url, jogo, httpOptions);
  }
  atualizar(jogo: Jogo): Observable<any> {
    const url = `${this.apiUrl}/atualizar`;
    return this.http.put<Jogo>(url, jogo, httpOptions);
  }
  excluir(id: number): Observable<any> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.delete<number>(url, httpOptions);
  }
}


