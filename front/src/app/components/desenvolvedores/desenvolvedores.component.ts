import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { DesenvolvedorService } from 'src/app/desenvolvedores.service';
import { Desenvolvedor } from 'src/app/Desenvolvedor';

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
    const usuario : Desenvolvedor = this.formulario.value;
    this.desenvolvedoresService.cadastrar(usuario).subscribe(result => {
      alert('Desenvolvedor inserido com sucesso.');
    })
  }
}
