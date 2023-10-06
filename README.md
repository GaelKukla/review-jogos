# Trabalho C#
## Alunos:
- Gabriel Martins Delfes;
- Gael Huk Kukla;
- Gabriell de Souza Zappelini;
- Pedro Henrique Cagol;
  
## Sobre o trabalho:
Criamos uma aplicação BakcEnd com o objetivo de realizar a avaliação de jogos, onde futuramente pretendemos até mesmo fazer uma conexão com uma Dataset da Steam, mas no momente ele possui um desenvolvimente a partir do SQLite, usando o CRUD.
### Como funciona:
-------------------
- Ao entrar na aplicação o usuário será redirecionado para uma pagina Web(Swagger UI).
- No Swagger UI será exibido algumas divisões, onde cada uma dessas divisões é uma Model e em casa uma tem o CRUD.
- O Usuario escolhe o que deseja que seja feito o CRUD e então clica sobre a opção, depois clica em "Try it out" para realizar essa ação.
- Após isso, o Usuario digita as informações desejadas e clica em "Execute", assim realizando uma ação no CRUD, que será salvo no banco de dados SQLite; 

### Especificações:
-------------------
<p>A aplicação contém 10 Models, que foram divididas entre os membros da equipe(incluindo o ChatGPT), estas Models são(Contendo ao lado quem o membro da equipe que fez a Model):</p>
<ul>
<li> <a href="Models/Usuario.cs">Usuario</a>  Feito por Gabriel Martins Delfes.</li>
<li> <a href="Models/Avaliacao.cs">Avaliacao</a> - Feito por Pedro Henrique Cagol.</li>
<li> <a href="Models/Jogo.cs">Jogo</a> - Feito por Pedro Henrique Cagol.</li>
<li> <a href="Models/Desenvolvedor.cs">Desenvolvedor</a> - Feito por Gabriel Martins Delfes.</li>
<li> <a href="Models/Comentario.cs">Comentario</a> - Feito por Gael Huk Kukla.</li>
<li> <a href="Models/Imagem.cs">Imagem</a> - Feito pelo ChatGPT.</li>
<li> <a href="Models/Tag.cs">Tag</a> - Feito pelo ChatGPT.</li>
<li> <a href="Models/Plataforma.cs">Plataforma</a> - Feito por Gael Huk Kukla.</li>
<li> <a href="Models/Genero.cs">Genero</a> - Feito por Gabriell de Souza Zappelini.</li>
<li> <a href="Models/Conquista.cs">Conquista</a> - Feito por Gabriell de Souza Zappelini.</li>
</ul>
<br>
<p> A aplicação contém 10 Controllers, que foram divididas entre os membros da equipe(incluindo o ChatGPT), estas Controllers são(Contendo ao lado quem o membro da equipe que fez a Controller):</p>
<ul>
<li> <a href="Controllers/UsuarioController.cs">UsuarioController</a>  Feito por Gabriel Martins Delfes.</li>
<li> <a href="Controllers/AvaliacaoController.cs">AvaliacaoController</a> - Feito por Pedro Henrique Cagol.</li>
<li> <a href="Controllers/JogoController.cs">JogoController</a> - Feito por Pedro Henrique Cagol.</li>
<li> <a href="Controllers/DesenvolvedorController.cs">DesenvolvedorController</a> - Feito por Gabriel Martins Delfes.</li>
<li> <a href="Controllers/ComentarioController.cs">ComentarioController</a> - Feito por Gael Huk Kukla.</li>
<li> <a href="Controllers/ImagemController.cs">ImagemController</a> - Feito pelo ChatGPT.</li>
<li> <a href="Controllers/TagController.cs">TagController</a> - Feito pelo ChatGPT.</li>
<li> <a href="Controllers/PlataformaController.cs">PlataformaController</a> - Feito por Gael Huk Kukla.</li>
<li> <a href="Controllers/GeneroController.cs">GeneroController</a> - Feito por Gabriell de Souza Zappelini.</li>
<li> <a href="Controllers/ConquistaController.cs">ConquistaController</a> - Feito por Gabriell de Souza Zappelini.</li>
</ul>

### Diagrama:
-------------------
<p>Nosso diagrama foi feito por meio de um site no qual ao criar o PDF do arquivo a qualidade se torna muito baixa, então segue o link para visualizar o diagrama:</p>
https://miro.com/app/board/uXjVMrZ388M=/?share_link_id=878885271494

