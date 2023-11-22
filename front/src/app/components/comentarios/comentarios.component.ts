import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ComentariosService } from 'src/app/comentarios.service';
import { Comentario } from 'src/app/Comentario';
import { Avaliacao } from 'src/app/Avaliacao';
import { AvaliacoesService } from './../../avaliacoes.service';
import { Observer } from 'rxjs';


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
        this.formulario.get('avaliacaoId')?.setValue(this.avaliacoes[0].id);
      }
    });


    this.formulario = new FormGroup({
      coment: new FormControl(null),
      avaliacaoId: new FormControl(null)
    });
    console.log(this.formulario.avaliacaoId)
  }
  enviarFormulario(): void {
    console.log('Método enviarFormulario() chamado.');
    const comentario: Comentario = this.formulario.value;
    const observer: Observer<Comentario> = {
        next(_result): void{
          alert('Modelo salvo com sucesso.');
        },
        error(_error): void {
          alert('Erro ao salvar!');

        },
        complete(): void {
        },
        };
      if (comentario.idComentario && !isNaN(Number(comentario.idComentario))){
        this.comentariosService.alterar(comentario).subscribe(observer);
      } else{
        this.comentariosService.cadastrar(comentario).subscribe(observer);
      }
    }
}
