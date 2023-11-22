import { Avaliacao } from "./Avaliacao";

export class Comentario {
  idComentario: number = 0;
  avaliacaoId: number = 0;
  avaliacao: Avaliacao | undefined;
  coment: string = '';
}
