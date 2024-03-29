import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Genero } from './Genero';
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class GenerosService {
  apiUrl = 'http://localhost:5000/Genero'
  constructor(private http: HttpClient) { }
  listar(): Observable<Genero[]> {
    const url = `${this.apiUrl}/listar`;
    return this.http.get<Genero[]>(url);
  }
  buscar(id: number): Observable<Genero> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.get<Genero>(url);
  }
  cadastrar(genero: Genero): Observable<any> {
    const url = `${this.apiUrl}/cadastrar`;
    return this.http.post<Genero>(url, genero, httpOptions);
  }
  alterar(genero: Genero): Observable<any> {
    const url = `${this.apiUrl}/alterar`;
    return this.http.put<Genero>(url, genero, httpOptions);
  }
  excluir(id: number): Observable<any> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.delete<number>(url, httpOptions);
  }
}
