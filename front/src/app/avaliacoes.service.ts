import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Avaliacao } from './Avaliacao';
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class AvaliacoesService {
  apiUrl = 'http://localhost:5000/Avaliacao';
  constructor(private http: HttpClient) { }
  listar(): Observable<Avaliacao[]> {
    const url = `${this.apiUrl}/listar`;
    return this.http.get<Avaliacao[]>(url);
  }
  buscar(id: number): Observable<Avaliacao> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.get<Avaliacao>(url);
  }
  cadastrar(avaliacao: Avaliacao): Observable<any> {
    const url = `${this.apiUrl}/cadastrar`;
    return this.http.post<Avaliacao>(url, avaliacao, httpOptions);
  }
  atualizar(avaliacao: Avaliacao): Observable<any> {
    const url = `${this.apiUrl}/atualizar`;
    return this.http.put<Avaliacao>(url, avaliacao, httpOptions);
  }
  excluir(id: number): Observable<any> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.delete<number>(url, httpOptions);
  }
}
