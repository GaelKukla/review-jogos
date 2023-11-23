import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Observer } from 'rxjs';
import { JogosService } from 'src/app/jogos.service';
import { Jogo } from 'src/app/Jogo';
import { Plataforma } from 'src/app/Plataforma';
import { PlataformasService } from 'src/app/plataformas.service';
import { Genero } from 'src/app/Genero';
import { GenerosService } from 'src/app/generos.service';
import { Desenvolvedor } from 'src/app/Desenvolvedor';
import { DesenvolvedorService } from 'src/app/desenvolvedores.service';


@Component({
  selector: 'app-jogos',
  templateUrl: './jogos.component.html',
  styleUrls: ['./jogos.component.css']
})
export class JogosComponent implements OnInit {
  formularioAvaliacao: any;
  tituloFormulario: string = '';
  plataformas: Array<Plataforma> | undefined;
  generos: Array<Genero> | undefined;
  desenvolvedores: Array<Desenvolvedor> | undefined;

  constructor(private jogosService: JogosService,
              private plataformasService: PlataformasService,
              private generosService: GenerosService,
              private desenvolvedoresService: DesenvolvedorService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Nova Conquista';

    this.generosService.listar().subscribe(generos => {
      this.generos = generos;
      if (this.generos && this.generos.length > 0){
        this.formularioAvaliacao.get('generoId')?.setValue(this.generos[0].idGenero);
      }
    });

    this.plataformasService.listar().subscribe(plataformas => {
      this.plataformas = plataformas;
      if (this.plataformas && this.plataformas.length > 0){
        this.formularioAvaliacao.get('plataformaId')?.setValue(this.plataformas[0].idPlataforma);
      }
    });

    this.desenvolvedoresService.listar().subscribe(desenvolvedores => {
      this.desenvolvedores = desenvolvedores;
      if (this.desenvolvedores && this.desenvolvedores.length > 0){
        this.formularioAvaliacao.get('desenvolvedorId')?.setValue(this.desenvolvedores[0].idDesenvolvedor);
      }
    });

    this.formularioAvaliacao = new FormGroup({
      nome: new FormControl(null),
      desenvolvedorId: new FormControl(null),
      plataformaId: new FormControl(null),
      generoId: new FormControl(null)
    })
  }
  enviarFormulario(): void {
    console.log('Método enviarFormularioAvaliacao() chamado.');
    const jogo: Jogo = this.formularioAvaliacao.value;

    const observer: Observer<Jogo> = {
        next(_result): void{
          alert('Modelo salvo com sucesso.');
        },
        error(_error): void {
          alert('Erro ao salvar!');
        },
        complete(): void {
        },
        };
      if (jogo.idJogo && !isNaN(Number(jogo.idJogo))){
        this.jogosService.alterar(jogo).subscribe(observer);
      } else{
        console.log(jogo.nome," ", jogo.desenvolvedor, " ", jogo.genero, " ", jogo.plataforma)
        this.jogosService.cadastrar(jogo).subscribe(observer);
      }
    }
}
