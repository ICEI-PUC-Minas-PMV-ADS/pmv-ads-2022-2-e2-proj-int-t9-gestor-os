
# Projeto de Interface

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Visão geral da interação do usuário pelas telas do sistema e protótipo interativo das telas com as funcionalidades que fazem parte do sistema (wireframes).

## Diagrama de Fluxo

Um diagrama de fluxo de dados (DFD) mapeia o fluxo de informações para qualquer processo ou sistema. Ele utiliza símbolos definidos, como retângulos, círculos e flechas, além de rótulos de textos breves, para mostrar entradas e saídas de dados, pontos de armazenamento e as rotas entre cada destino.
Aqui segue o diagrama de fluxo da aplicação:

<img src=" img/DiagramaFluxo.png">

As referências abaixo irão auxiliá-lo na geração do artefato “Diagramas de Fluxo”.

> **Links Úteis**:
> - [Fluxograma online: seis sites para fazer gráfico sem instalar nada | Produtividade | TechTudo](https://www.techtudo.com.br/listas/2019/03/fluxograma-online-seis-sites-para-fazer-grafico-sem-instalar-nada.ghtml)

## Wireframes

Nesta seção apresentamos o wireframe do projeto, como protótipo das telas da aplicação, bem como relacionamento entre elas. Em um primeiro momento, veremos o projeto em sua totalidade, para, em seguida, nos aprofundar em cada função do sistema de gerenciamento de ordens de serviço. No final, oferecemos uma oportunidade para visualizar o projeto em uma visualização interativa.


<img src="img/WireframeCompleto.png">

Como podemos ver, na página inicial já se encontram disponíveis as três funcionalidades para o usuário: a opção de ir para o ambiente do cliente do serviço do setor de facilities da empresa, a opção de seguir como administrador (o responsável por cumprir as ordens de serviço emanadas pelo cliente), bem como a oportunidade de criar seu cadastro no sistema, caso seja um novo usuário. A serguir, debruçaremos sobre cada funcionalidade em separado.

<br><br>
<strong>Ambiente do Cliente</strong>

Começando pelo ambiente do cliente, após selecionar a opção "cliente" na página inicial, o usuário será levado a um ambiente de login, no qual estrará com seus dados de acesso. Após isso, será disponibilidade uma tela para que sejam fornecidas as informações acerca do serviço a ser realizado: 
> <ul>
> <il>- Natureza do serviço a ser realizado;</il><br>
> <il>- Opção para fornecer detalhes sobre a solicitação;</il><br>
> <il>- Opção para selecionar o melhor dia para o serviço ser realizado;</il><br>
> <il>- Campo para definir a data limite para o serviço ser realizado, caso a data ideal não possa ser atendida.</il><br>
> </ul>
Por fim, ao salvar a ordem de serviço, o usuário será direcionado para uma nova tela de confirmação de solicitação de serviço, contendo o protocolo da ordem de serviço gerada. Essa funcionalidade, contudo, poderá ser substituída por um pop-up.

<img src="img/WireframeGerarOS.png">

<br><br>
<strong>Ambiente do Administrador</strong>


Já no ambiente do administrador, após selecionar a opção na página inicial, temos uma tela login semelhante ao fornecido para o cliente, com as alterações típicas de estilo. Após entrar no sistema, o administrador terá disponível uma tela em que poderá ver as novas ordens de serviço geradas pelos clientes, bem como quais serviços estão em andamento, e os trabalhos que já foram finalizados, de modo que poderá acompanhar o desempenho e emprego da equipe.

<img src="img/WireframeAdministrador.png">

<br><br>
<strong>Ambiente do Novo Usuário</strong>

Caso seja um novo usuário do sistema de gerenciamento de ordens de serviço, na página inicial da aplicação terá uma opção para realizar seu cadastro. Após selecionar essa opção, o usuário será direcionado para um abiente no qual ele irá fornecer informações a seu respeito, tais como:

> <ul>
> <il>- Nome;</il><br>
> <il>- Setor da empresa no qual trabalha;</il><br>
> <il>- Telefone para contato;</il><br>
> <il>- E-mail;</il><br>
> <il>- Senha para cadastro no sistema;</il><br>
> <il>- Tipo de perfil de usuário: cliente ou administrador.</il><br>
> </ul>

<img src="img/WireframeNovoUsuário.png">

Conforme dito no inicio desta seção, para melhor compreensão e visualização, oferecemos uma versão interativa, <a href="https://app.uizard.io/p/c54734e5">basta clicar aqui!</a>
