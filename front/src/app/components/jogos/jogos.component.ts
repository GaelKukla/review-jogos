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
  formulario: any;
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
        this.formulario.get('genero')?.setValue(this.generos[0].idGenero);
      }
    });

    this.plataformasService.listar().subscribe(plataformas => {
      this.plataformas = plataformas;
      if (this.plataformas && this.plataformas.length > 0){
        this.formulario.get('plataformaId')?.setValue(this.plataformas[0].id);
      }
    });

    this.desenvolvedoresService.listar().subscribe(desenvolvedores => {
      this.desenvolvedores = desenvolvedores;
      if (this.desenvolvedores && this.desenvolvedores.length > 0){
        this.formulario.get('desenvolvedor')?.setValue(this.desenvolvedores[0].iddesenvolvedor);
      }
    });

    this.formulario = new FormGroup({
      plataformaId: new FormControl(null),
      desenvolvedor: new FormControl(null),
      genero: new FormControl(null),
      nome: new FormControl(null),
    })
  }
  enviarFormulario(): void {
    console.log('Método enviarFormulario() chamado.');
    const jogo: Jogo = this.formulario.value;

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
      if (jogo.id && !isNaN(Number(jogo.id))){
        this.jogosService.alterar(jogo).subscribe(observer);
      } else{
        this.jogosService.cadastrar(jogo).subscribe(observer);
      }
    }
}
