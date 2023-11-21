import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ConquistasService } from 'src/app/conquistas.service';
import { Conquista } from 'src/app/Conquista';
import { JogosService } from 'src/app/jogos.service';
import { Jogo } from 'src/app/Jogo';
import { Observer } from 'rxjs';

@Component({
  selector: 'app-conquistas',
  templateUrl: './conquistas.component.html',
  styleUrls: ['./conquistas.component.css']
})
export class ConquistasComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';
  jogos: Array<Jogo> | undefined;
  constructor(private conquistasService : ConquistasService, private jogosService: JogosService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Nova Conquista';
    this.jogosService.listar().subscribe(jogos => {
      this.jogos = jogos;
      if (this.jogos && this.jogos.length > 0){
        this.formulario.get('jogoId')?.setValue(this.jogos[0].id);
      }
    });

    this.formulario = new FormGroup({
      jogoId: new FormControl(null),
      tipo: new FormControl(null),
      descricao: new FormControl(null)
    })
  }
  enviarFormulario(): void {
    console.log('Método enviarFormulario() chamado.');
    const jogo: Jogo = this.formulario.value;
    const observer: Observer<Conquista> = {
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
        this.jogosService.atualizar(jogo).subscribe(observer);
      } else{
        this.jogosService.cadastrar(jogo).subscribe(observer);
      }
    }
}
