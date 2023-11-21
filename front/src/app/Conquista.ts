import { Jogo } from "./Jogo";


export class Conquista {
    idConquista: number = 0;
    jogoId: number = 0;
    jogo: Jogo | undefined;
    tipo: string = '';
    descricao: string = '';
  }