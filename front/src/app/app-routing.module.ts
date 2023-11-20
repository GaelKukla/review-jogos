import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ComentariosComponent } from './components/comentarios/comentarios.component';
import { AvaliacoesComponent } from './components/avaliacoes/avaliacoes.component';
import { ConquistasComponent } from './components/conquistas/conquistas.component';
import { DesenvolvedoresComponent } from './components/desenvolvedores/desenvolvedores.component';
import { GenerosComponent } from './components/generos/generos.component';
import { ImagensComponent } from './components/imagens/imagens.component';
import { JogosComponent } from './components/jogos/jogos.component';
import { PlataformasComponent } from './components/plataformas/plataformas.component';
import { TagsComponent } from './components/tags/tags.component';
import { UsuariosComponent } from './components/usuarios/usuarios.component';


const routes: Routes = [
  {path: 'avaliacoes', component:AvaliacoesComponent},
  {path: 'comentarios', component:ComentariosComponent},
  {path: 'conquistas', component:ConquistasComponent},
  {path: 'desenvolvedores', component:DesenvolvedoresComponent},
  {path: 'generos', component:GenerosComponent},
  {path: 'imagens', component:ImagensComponent},
  {path: 'jogos', component:JogosComponent},
  {path: 'plataformas', component:PlataformasComponent},
  {path: 'tags', component:TagsComponent},
  {path: 'usuarios', component:UsuariosComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
