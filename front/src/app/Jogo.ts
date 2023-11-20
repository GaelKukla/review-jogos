import { Plataforma } from "./Plataforma";
import { Desenvolvedor } from "./Desenvolvedor";
import { Genero } from "./Genero";

export class Jogo {
    id: number = 0;
    plataformaId: number = 0;
    plataforma: Plataforma | undefined;
    desenvolvedor: Desenvolvedor | undefined;
    genero: Genero | undefined;
    nome: string = '';
  }