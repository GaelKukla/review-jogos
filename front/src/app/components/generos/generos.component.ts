import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { GenerosService } from 'src/app/generos.service';
import { Genero } from 'src/app/Genero';
import { JogosService } from 'src/app/jogos.service';
import { Jogo } from 'src/app/Jogo';
import { Observer } from 'rxjs';

@Component({
  selector: 'app-generos',
  templateUrl: './generos.component.html',
  styleUrls: ['./generos.component.css']
})
export class GenerosComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';
  jogos: Array<Jogo> | undefined;
  constructor(private generosService : GenerosService, private jogosService: JogosService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Novo Genero';

    this.formulario = new FormGroup({
      tipo: new FormControl(null),
      descricao: new FormControl(null)
    })
  }
  enviarFormulario(): void {
    console.log('Método enviarFormulario() chamado.');
    const genero: Genero = this.formulario.value;
    const observer: Observer<Genero> = {
        next(_result): void{
          alert('Modelo salvo com sucesso.');
        },
        error(_error): void {
          alert('Erro ao salvar!');
        },
        complete(): void {
        },
        };
      if (genero.idGenero && !isNaN(Number(genero.idGenero))){
        this.generosService.alterar(genero).subscribe(observer);
      } else{
        this.generosService.cadastrar(genero).subscribe(observer);
      }
    }
  }
