import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ComentariosService } from 'src/app/comentarios.service';
import { Comentario } from 'src/app/Comentario';
import { Avaliacao } from 'src/app/Avaliacao';
import { AvaliacoesService } from './../../avaliacoes.service';

@Component({
  selector: 'app-comentarios',
  templateUrl: './comentarios.component.html',
  styleUrls: ['./comentarios.component.css']
})
export class ComentariosComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';
  avaliacoes: Array<Avaliacao> | undefined;

  constructor(private comentariosService : ComentariosService,
              private avaliacoesService : AvaliacoesService,) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Novo Comentario';
    this.avaliacoesService.listar().subscribe(avaliacoes => {
      this.avaliacoes = avaliacoes;
      if (this.avaliacoes && this.avaliacoes.length > 0) {
        this.formulario.get('avaiacaoId')?.setValue(this.avaliacoes[0].id);
      }
    });


    this.formulario = new FormGroup({
      id: new FormControl(null),
      coment: new FormControl(null)
    })
  }
  enviarFormulario(): void {
    const comentario : Comentario = this.formulario.value;
    this.comentariosService.cadastrar(comentario).subscribe(result => {
      alert('Comentario inserido com sucesso.');
    })
  }
}
