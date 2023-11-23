import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { PlataformasService } from 'src/app/plataformas.service';
import { Plataforma } from 'src/app/Plataforma';
import { Observer } from 'rxjs';

@Component({
  selector: 'app-plataformas',
  templateUrl: './plataformas.component.html',
  styleUrls: ['./plataformas.component.css']
})
export class PlataformasComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';
  constructor(private plataformasService : PlataformasService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Novo Plataforma';

    this.formulario = new FormGroup({
      tipo: new FormControl(null),
      descricao: new FormControl(null)
    })
  }
  enviarFormulario(): void {
    console.log('Método enviarFormulario() chamado.');
    const plataforma: Plataforma = this.formulario.value;
    const observer: Observer<Plataforma> = {
        next(_result): void{
          alert('Modelo salvo com sucesso.');
        },
        error(_error): void {
          alert('Erro ao salvar!');
        },
        complete(): void {
        },
        };
      if (plataforma.idPlataforma && !isNaN(Number(plataforma.idPlataforma))){
        this.plataformasService.alterar(plataforma).subscribe(observer);
      } else{
        this.plataformasService.cadastrar(plataforma).subscribe(observer);
      }
    }
}
