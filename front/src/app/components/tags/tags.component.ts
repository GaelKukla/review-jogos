import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { TagsService } from 'src/app/tags.service';
import { Tag } from 'src/app/Tag';
import { Observer } from 'rxjs';


@Component({
  selector: 'app-tags',
  templateUrl: './tags.component.html',
  styleUrls: ['./tags.component.css']
})
export class TagsComponent implements OnInit {
  formulario: any;
  tituloFormulario: string = '';
  constructor(private tagService : TagsService) { }

  ngOnInit(): void {
    this.tituloFormulario = 'Novo Tag';

    this.formulario = new FormGroup({
      nome: new FormControl(null),
      descricao: new FormControl(null)
    })
  }
  enviarFormulario(): void {
    console.log('Método enviarFormulario() chamado.');
    const tag: Tag = this.formulario.value;
    const observer: Observer<Tag> = {
        next(_result): void{
          alert('Modelo salvo com sucesso.');
        },
        error(_error): void {
          alert('Erro ao salvar!');
        },
        complete(): void {
        },
        };
      if (tag.id && !isNaN(Number(tag.id))){
        this.tagService.alterar(tag).subscribe(observer);
      } else{
        this.tagService.cadastrar(tag).subscribe(observer);
      }
    }
}
