import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { PlataformasService } from 'src/app/plataformas.service';
import { Plataforma } from 'src/app/Plataforma';

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
    const plataforma : Plataforma = this.formulario.value;
    this.plataformasService.cadastrar(plataforma).subscribe(result => {
      alert('Plataforma inserida com sucesso.');
    })
  }
}
