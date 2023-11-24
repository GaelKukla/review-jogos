import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Imagem } from './Imagem';
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class ImagensService {
  apiUrl = 'http://localhost:5000/imagem';
  constructor(private http: HttpClient) { }
  listar(): Observable<Imagem[]> {
    const url = `${this.apiUrl}/listar`;
    return this.http.get<Imagem[]>(url);
  }
  buscar(id: number): Observable<Imagem> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.get<Imagem>(url);
  }
  cadastrar(imagem: Imagem): Observable<any> {
    const url = `${this.apiUrl}/cadastrar`;
    return this.http.post<Imagem>(url, imagem, httpOptions);
  }
  alterar(imagem: Imagem): Observable<any> {
    const url = `${this.apiUrl}/alterar`;
    return this.http.put<Imagem>(url, imagem, httpOptions);
  }
  excluir(id: number): Observable<any> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.delete<number>(url, httpOptions);
  }
}
