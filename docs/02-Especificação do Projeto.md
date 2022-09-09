# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas   
Persona 1: Aline Alves, 32 anos, Atua na administração há 15 anos e seu hobbie preferido é administrar empresas. Atualmente sofre com problemas no gerenciamento de OSs, onde não há informações suficientes e nem locais adequados (Uso de email para realização), onde resulta no atraso de pedidos e falta de organização das OS. Aline busca formas de solucionar esse problema por meio de aplicações web.

<br>
<br>
Persona 2: Lucas Alexandre, 39 anos, Colaborador no setor de engenharia da empresa, Lucas está motivado em trabalhar no seu crescimento profissional, atuando  nos setores de facility da  empresa. 
Lucas busca uma forma mais moderna de enviar solicitações de OS para mais detalhamento e agilidade nos pedidos.



## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `ALINE ALVES`| QUERO/PRECISO ... `FUNCIONALIDADE`                                   |PARA ... `MOTIVO/VALOR`                                                       |
|------------------------|----------------------------------------------------------------------|------------------------------------------------------------------------------|
|Administrador do sistema| Visualizar de maneira mais clara a quantidade de OSs solicitada      | Poder dimensionar os recursos de trabalho                                    |
|Administrador do sistema| Saber o deadline dado pelo solicitante                               | Planejar com antecedencia o cronograma                                       |
|Administrador do sistema| Saber de forma otimizada o escopo a ser trabalhado                   | Pode alocar os recursos com mais facilidade a depender do tipo da atividade  |  
|Administrador do sistema| Saber as datas de criação das OSs                                    | Para poder dar prioridade às mais antigas. Quando possuírem escopos similares|                                       
|Administrador do sistema| Saber a quantidade de solicitações por setor/disciplina e solicitante| Ter a estatística de maiores solicitantes e setores                          |



|EU COMO... `Lucas alexandre`| QUERO/PRECISO ... `FUNCIONALIDADE`              |PARA ... `MOTIVO/VALOR`                                        |
|------------------------|-----------------------------------------------------|---------------------------------------------------------------|
|Usuário do sistema      | Agilidade no envio das solicitações                 | O atual processo é inconsistente e não confiável              |
|Usuário do sistema      | Especificar data de prazo para o facility           | Para ter o atendimento na data correta: nem antes nem depois  |
|Usuário do sistema      | Ter um local único [hub] onde os pedidos são feito  |O processo atual, feitos via e-mail, não são padronizados      |  

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito                                                                                                                        |Prioridade|
|------|-----------------------------------------------------------------------------------------------------------------------------------------------|----------|
|RF-001| O site deve apresentar uma tela inicial para cada tipo de login o usuário deseja realizar.                                                    |Alta      |
|RF-002| Após o login, o site deve apresentar uma tela relacionada ao tipo de login que o usuário escolheu inicialmente.                               |Alta      |
|RF-003| Na tela de entrada de dados da OS devem haver campos para o usuário informar o escopo de sua requisição.                                      |Alta      |
|RF-004| Na tela de gerenciamento de OS, o site deverá exibir uma barra de pesquisa onde ao pesquisar as datas ou os tipos das OS elas serão exibidas. |Alta      |
|RF-005| O site deve exibir uma notificação informando que a solicitação foi salva pelo sistema.                                                       |Média     |
|RF-006| Na tela de gerenciamento de OS,o site deve exibir um procedimento para exclusão de OS                                                         |Alta      |
 

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
