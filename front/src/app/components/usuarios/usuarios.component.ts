import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { UsuarioService } from 'src/app/usuarios.service';
import { Usuario } from 'src/app/Usuario';
import { Observer } from 'rxjs';

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
    console.log('Método enviarFormulario() chamado.');
    const usuario: Usuario = this.formulario.value;
    const observer: Observer<Usuario> = {
        next(_result): void{
          alert('Modelo salvo com sucesso.');
        },
        error(_error): void {
          alert('Erro ao salvar!');
        },
        complete(): void {
        },
        };
      if (usuario.idUsuario && !isNaN(Number(usuario.idUsuario))){
        this.usuariosService.alterar(usuario).subscribe(observer);
      } else{
        this.usuariosService.cadastrar(usuario).subscribe(observer);
      }
    }
}
