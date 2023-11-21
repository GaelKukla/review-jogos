import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Conquista } from './Conquista';
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class ConquistasService {
  apiUrl = 'http://localhost:5000/Conquistas'
  constructor(private http: HttpClient) { }
  listar(): Observable<Conquista[]> {
    const url = `${this.apiUrl}/listar`;
    return this.http.get<Conquista[]>(url);
  }
  buscar(id: number): Observable<Conquista> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.get<Conquista>(url);
  }
  cadastrar(conquista: Conquista): Observable<any> {
    const url = `${this.apiUrl}/cadastrar`;
    return this.http.post<Conquista>(url, conquista, httpOptions);
  }
  alterar(conquista: Conquista): Observable<any> {
    const url = `${this.apiUrl}/alterar`;
    return this.http.put<Conquista>(url, conquista, httpOptions);
  }
  excluir(id: number): Observable<any> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.delete<number>(url, httpOptions);
  }
}
