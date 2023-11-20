import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Desenvolvedor } from './Desenvolvedor';
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class DesenvolvedorService {
  apiUrl = 'http://localhost:5000/Desenvolvedor';
  constructor(private http: HttpClient) { }
  listar(): Observable<Desenvolvedor[]> {
    const url = `${this.apiUrl}/listar`;
    return this.http.get<Desenvolvedor[]>(url);
  }
  buscar(id: number): Observable<Desenvolvedor> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.get<Desenvolvedor>(url);
  }
  cadastrar(desenvolvedor: Desenvolvedor): Observable<any> {
    const url = `${this.apiUrl}/cadastrar`;
    return this.http.post<Desenvolvedor>(url, desenvolvedor, httpOptions);
  }
  atualizar(desenvolvedor: Desenvolvedor): Observable<any> {
    const url = `${this.apiUrl}/atualizar`;
    return this.http.put<Desenvolvedor>(url, desenvolvedor, httpOptions);
  }
  excluir(id: number): Observable<any> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.delete<number>(url, httpOptions);
  }
}


