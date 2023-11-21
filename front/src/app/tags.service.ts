import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Tag } from './Tag';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type' : 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class TagsService {
  apiUrl = 'http://localhost:5000/Tag';
  constructor(private http: HttpClient) { }
  listar(): Observable<Tag[]> {
    const url = `${this.apiUrl}/listar`;
    return this.http.get<Tag[]>(url);
  }
  buscar(id: number): Observable<Tag> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.get<Tag>(url);
  }
  cadastrar(tag: Tag): Observable<any> {
    const url = `${this.apiUrl}/cadastrar`;
    return this.http.post<Tag>(url, tag, httpOptions);
  }
  alterar(tag: Tag): Observable<any> {
    const url = `${this.apiUrl}/alterar`;
    return this.http.put<Tag>(url, tag, httpOptions);
  }
  excluir(id: number): Observable<any> {
    const url = `${this.apiUrl}/buscar/${id}`;
    return this.http.delete<number>(url, httpOptions);
  }
}


