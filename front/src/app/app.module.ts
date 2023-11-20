import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { ReactiveFormsModule } from '@angular/forms';
import { ModalModule} from 'ngx-bootstrap/modal';

import { ComentariosService } from './comentarios.service';
import { ComentariosComponent } from './components/comentarios/comentarios.component';

import { AvaliacoesService } from './avaliacoes.service';
import { AvaliacoesComponent } from './components/avaliacoes/avaliacoes.component';

import { ConquistasService } from './conquistas.service';
import { ConquistasComponent } from './components/conquistas/conquistas.component';

import { DesenvolvedorService } from './desenvolvedores.service';
import { DesenvolvedoresComponent } from './components/desenvolvedores/desenvolvedores.component';

import { GenerosService } from './generos.service';
import { GenerosComponent } from './components/generos/generos.component';

import { ImagensService } from './imagens.service';
import { ImagensComponent } from './components/imagens/imagens.component';

import { JogosService } from './jogos.service';
import { JogosComponent } from './components/jogos/jogos.component';

import { PlataformasService } from './plataformas.service';
import { PlataformasComponent } from './components/plataformas/plataformas.component';

import { TagsService } from './tags.service';
import { TagsComponent } from './components/tags/tags.component';

import { UsuarioService } from './usuarios.service';
import { UsuariosComponent } from './components/usuarios/usuarios.component';

@NgModule({
  declarations: [
    AppComponent,
    ComentariosComponent,
    AvaliacoesComponent,
    ConquistasComponent,
    DesenvolvedoresComponent,
    GenerosComponent,
    ImagensComponent,
    JogosComponent,
    PlataformasComponent,
    TagsComponent,
    UsuariosComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CommonModule,
    HttpClientModule,
    ReactiveFormsModule,
    ModalModule.forRoot()
  ],
  providers: [HttpClientModule, ComentariosService, AvaliacoesService, ConquistasService, DesenvolvedorService, GenerosService,
     ImagensService, JogosService, PlataformasService, TagsService, UsuarioService],
  bootstrap: [AppComponent]
})
export class AppModule { }
