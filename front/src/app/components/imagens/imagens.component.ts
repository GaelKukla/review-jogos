import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ImagensService } from 'src/app/imagens.service';
import { Imagem } from 'src/app/Imagem';
import { Jogo } from 'src/app/Jogo';
import { JogosService } from 'src/app/jogos.service';
import { Observer } from 'rxjs';

@Component({
  selector: 'app-imagens',
  templateUrl: './imagens.component.html',
  styleUrls: ['./imagens.component.css']
})
export class ImagensComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';
  jogos: Array<Jogo> | undefined;

  constructor(private imagensService : ImagensService,
              private jogosService : JogosService,) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Nova Imagem';
    this.jogosService.listar().subscribe(jogos => {
      this.jogos = jogos;
      if (this.jogos && this.jogos.length > 0) {
        this.formulario.get('jogoId')?.setValue(this.jogos[0].idJogo);
      }
    });


    this.formulario = new FormGroup({
      url: new FormControl(null)
    })
  }
  enviarFormulario(): void {
    console.log('Método enviarFormulario() chamado.');
    const imagem: Imagem = this.formulario.value;
    const observer: Observer<Imagem> = {
        next(_result): void{
          alert('Modelo salvo com sucesso.');
        },
        error(_error): void {
          alert('Erro ao salvar!');
        },
        complete(): void {
        },
        };
      if (imagem.idImagem&& !isNaN(Number(imagem.idImagem))){
        this.imagensService.alterar(imagem).subscribe(observer);
      } else{
        this.imagensService.cadastrar(imagem).subscribe(observer);
      }
    }
}
