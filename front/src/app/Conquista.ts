import { Jogo } from "./Jogo";


export class Comentario {
    id: number = 0;
    jogoId: number = 0;
    jogo: Jogo | undefined;
    tipo: string = '';
    descricao: string = '';
  }