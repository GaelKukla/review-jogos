import { Plataforma } from "./Plataforma";
import { Desenvolvedor } from "./Desenvolvedor";
import { Genero } from "./Genero";

export class Jogo {
    idJogo: number = 0;
    plataformaId: number = 0;
    plataforma: Plataforma | undefined;
    desenvolvedorId: number = 0;
    desenvolvedor: Desenvolvedor | undefined;
    generoId: number = 0;
    genero: Genero | undefined;
    nome: string = '';
  }
