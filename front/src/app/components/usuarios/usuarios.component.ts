import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { UsuarioService } from 'src/app/usuarios.service';
import { Usuario } from 'src/app/Usuario';

@Component({
  selector: 'app-usuarios',
  templateUrl: './usuarios.component.html',
  styleUrls: ['./usuarios.component.css']
})
export class UsuariosComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';

  constructor(private usuariosService : UsuarioService,) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Novo usuario';


    this.formulario = new FormGroup({
      // idusuario: new FormControl(null),
      nome: new FormControl(null),
      senha: new FormControl(null)
    })
  }
  enviarFormulario(): void {
    const usuario : Usuario = this.formulario.value;
    this.usuariosService.cadastrar(usuario).subscribe(result => {
      alert('Usuario inserido com sucesso.');
    })
  }
}
