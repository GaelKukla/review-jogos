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
  formularioConquista: any;
  tituloFormulario: string = '';
  constructor(private conquistasService : ConquistasService, private jogosService: JogosService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Nova Conquista';



    this.formularioConquista = new FormGroup({
      tipo: new FormControl(null),
      descricao: new FormControl(null)
    })
  }
  enviarFormulario(): void {
    console.log('Método enviarFormulario() chamado.');
    const conquista: Conquista = this.formularioConquista.value;
    const observer: Observer<Conquista> = {
        next(_result): void{
          alert('Modelo salvo com sucesso.');
        },
        error(_error): void {
          alert('Erro ao salvar!');
        },
        complete(): void {
        }
        };
      if (conquista.idConquista && !isNaN(Number(conquista.idConquista))){
        this.conquistasService.alterar(conquista).subscribe(observer);
      } else{
        this.conquistasService.cadastrar(conquista).subscribe(observer);
      }
    }
}
