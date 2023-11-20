import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Plataforma } from './Plataforma';
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class PlataformasService {
  apiUrl = 'http://localhost:5000/Plataforma';
  constructor(private http: HttpClient) { }
  listar(): Observable<Plataforma[]> {
    const url = `${this.apiUrl}/listar`;
    return this.http.get<Plataforma[]>(url);
  }
  buscar(id: number): Observable<Plataforma> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.get<Plataforma>(url);
  }
  cadastrar(plataforma: Plataforma): Observable<any> {
    const url = `${this.apiUrl}/cadastrar`;
    return this.http.post<Plataforma>(url, plataforma, httpOptions);
  }
  atualizar(plataforma: Plataforma): Observable<any> {
    const url = `${this.apiUrl}/atualizar`;
    return this.http.put<Plataforma>(url, plataforma, httpOptions);
  }
  excluir(id: number): Observable<any> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.delete<number>(url, httpOptions);
  }
}