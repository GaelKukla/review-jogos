import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { DesenvolvedorService } from 'src/app/desenvolvedores.service';
import { Desenvolvedor } from 'src/app/Desenvolvedor';
import { Observer } from 'rxjs';

@Component({
  selector: 'app-desenvolvedores',
  templateUrl: './desenvolvedores.component.html',
  styleUrls: ['./desenvolvedores.component.css']
})
export class DesenvolvedoresComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';

  constructor(private desenvolvedoresService : DesenvolvedorService,) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Novo desenvolvedor';


    this.formulario = new FormGroup({
      // idusuario: new FormControl(null),
      nome: new FormControl(null),
    })
  }
  enviarFormulario(): void {
    console.log('Método enviarFormulario() chamado.');
    const desenvolvedor: Desenvolvedor = this.formulario.value;
    const observer: Observer<Desenvolvedor> = {
        next(_result): void{
          alert('Modelo salvo com sucesso.');
        },
        error(_error): void {
          alert('Erro ao salvar!');
        },
        complete(): void {
        },
        };
      if (desenvolvedor.idDesenvolvedor && !isNaN(Number(desenvolvedor.idDesenvolvedor))){
        this.desenvolvedoresService.alterar(desenvolvedor).subscribe(observer);
      } else{
        this.desenvolvedoresService.cadastrar(desenvolvedor).subscribe(observer);
      }
    }
}
