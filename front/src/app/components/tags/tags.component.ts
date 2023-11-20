import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { TagsService } from 'src/app/tags.service';
import { Tag } from 'src/app/Tag';

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
    const tag : Tag = this.formulario.value;
    this.tagService.cadastrar(tag).subscribe(result => {
      alert('Tag inserida com sucesso.');
    })
  }
}
