import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Observer } from 'rxjs';
import { AvaliacoesService } from 'src/app/avaliacoes.service';
import { Avaliacao } from 'src/app/Avaliacao'
import { Comentario } from 'src/app/Comentario';
import { ComentariosService } from 'src/app/comentarios.service';

@Component({
  selector: 'app-avaliacoes',
  templateUrl: './avaliacoes.component.html',
  styleUrls: ['./avaliacoes.component.css']
})
export class AvaliacoesComponent {

}
