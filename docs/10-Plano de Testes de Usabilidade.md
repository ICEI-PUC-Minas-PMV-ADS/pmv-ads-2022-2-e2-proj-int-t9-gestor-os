# Plano de Testes de Usabilidade

>O objetivo desse teste é receber o feedback do usuário, certificando-se que o aplicativo entrega o esperado e funciona corretamente. Serão 5 (cinco) participantes. 

- Usuário terá acesso ao aplicativo de forma online;
- O método escolhido será por avaliação e criterização de variáveis qualitativas dos artefatos-chave. Sendo o usuário acompanhado por um auditor da equipe desenvolvedora.

>Criamos 3 (tres) atividades a serem cumpridas pelos candidatos, as quais estão ligadas aos 5 (cinco) requisitos críticos funcionais **[RF]** abaixo descritos:     

## Escopo 

> Decidiu-se no plano de usabilidade dar foco a controles-chave (críticos) para a interface do aplicativo. E nos quais haja maior possibilidade tanto de erro de programação quanto de intuitividade no uso para o usuário final, como se segue abaixo:


|ID    | Descrição do Requisito  | Atividades|
|------|---------------------------------------------------------------------------|---------------------------------------------|
|RF-001| A aplicação deverá apresentar uma tela onde o usuário poderá fazer login com "Email" e "Senha" e escolher qual tipo de usúario. | Verificar se os campos senha e login estão codificados de maneira a rotear corretamente o usuário para a tela determinada, além de ser claro seu uso: se cliente, criação das OS's, se administrador, para a tela de gestão das OS's |
|RF-002| A aplicação deverá apresentar uma tela onde o cliente poderá fazer a solicitação de OS onde haverão campos para informar o escopo de requisição tais como: Descrição, tipo, data , horário e realização da OS. | Verificar se o controle de seleção de data esta codificado corretamente e intuitivo |
|RF-003| A aplicação deverá exibir uma tela para o Admnistrador onde ele poderá alterar, editar , excluir e criar ordens de serviços  |  Verificar se o controle de conclusão da OS esta corretamente codificado
|RF-004| A aplicação deverá exibir uma tela para pesquisar as OS's | Verificar se a pesquisa vai ser executada corretamente
|RF-005| A aplicação deverá exibir uma tela para o Admin gerenciar os Usuários.	 | Verificar se o Admin irá conseguir gerenciar os usuários corretamente


## Tipo de coletor de dado

> Ao liberar o acesso ao ambiente sandbox, cada usuário recebeu um modelo de arquivo ".docx", do Microsoft Word, previamente populado com as seguintes tabelas, agrupadas por requisito, da seguinte forma: RF/Artefato de teste. 

#### Efetuar Login

- Tabela Login - artefato de teste: Controle inputTextSenha (campo senha);
###### Atributos/colunas/variáveis coletadas na tabela
> | Usuario|Idade|Artefato|Clicks|Quantidade de erros| Persistencia do erro| Comentário|
> |-----------|-----|------------|-------|----------|-------------|----------
###### dados coletados na tabela
>| Nome do usuario|Idade do usuário |Artefato testado pelo usuário|Clicks é a quantidade de cliques/ações realizadas pelo usuário sobre o artefato (inputTextSenha)| Número de erros verificados durante o teste| Descrição se o erro persistiu, sim ou não (uma lista de validação) após tratativa em tempo real do código| Comentário do auditor da equipe sobre o erro verificado|
>|----------------|------------|----------------|----------|--------|------------|---------|

***
- Tabela Login - artefato de teste: Controle inputTextLogin (campo login).
> | Usuario|Idade|Artefato|Clicks|Quantidade de erros| Persistencia do erro| Comentário|
> |-----------|-----|------------|-------|----------|-------------|----------
###### dados coletados na tabela
>| Nome do usuario|Idade do usuário |Artefato testado pelo usuário|Clicks é a quantidade de cliques/ações realizadas pelo usuário sobre o artefato (inputTextLogin)| Número de erros verificados durante o teste| Descrição se o erro persistiu, sim ou não (uma lista de validação) após tratativa em tempo real do código| Comentário do auditor da equipe sobre o erro verificado|
>|----------------|------------|----------------|----------|--------|------------|---------|

#### Criar OS's

- Tabela Criar Login - artefato de teste: Controle datePicker (campo seleção de data desejada de execução da OS).
> | Usuario|Idade|Artefato|Clicks|Quantidade de erros| Persistencia do erro| Comentário|
> |-----------|-----|------------|-------|----------|-------------|----------
###### dados coletados na tabela
>| Nome do usuario|Idade do usuário |Artefato testado pelo usuário|Clicks é a quantidade de cliques/ações realizadas pelo usuário sobre o artefato (datePicker)| Número de erros verificados durante o teste| Descrição se o erro persistiu, sim ou não (uma lista de validação) após tratativa em tempo real do código| Comentário do auditor da equipe sobre o erro verificado|
>|----------------|------------|----------------|----------|--------|------------|---------|


#### Gestão da OS

- Tabela Gestão de OS - artefato de teste: Controle checkBox (campo de "feito", conclusão da tratativa da OS)
> | Usuario|Idade|Artefato|Clicks|Quantidade de erros| Persistencia do erro| Comentário|
> |-----------|-----|------------|-------|----------|-------------|----------
###### dados coletados na tabela
>| Nome do usuario|Idade do usuário |Artefato testado pelo usuário|Clicks é a quantidade de cliques/ações realizadas pelo usuário sobre o artefato (checkBox)| Número de erros verificados durante o teste| Descrição se o erro persistiu, sim ou não (uma lista de validação) após tratativa em tempo real do código| Comentário do auditor da equipe sobre o erro verificado|
>|----------------|------------|----------------|----------|--------|------------|---------|


#### Pesquisar OS

- Tabela Login - artefato de teste: Controle SearchBox (campo Pesquisar);
###### Atributos/colunas/variáveis coletadas na tabela
> | Usuario|Idade|Artefato|Clicks|Quantidade de erros| Persistencia do erro| Comentário|
> |-----------|-----|------------|-------|----------|-------------|----------
###### dados coletados na tabela
>| Nome do usuario|Idade do usuário |Artefato testado pelo usuário|Clicks é a quantidade de cliques/ações realizadas pelo usuário sobre o artefato (inputTextSenha)| Número de erros verificados durante o teste| Descrição se o erro persistiu, sim ou não (uma lista de validação) após tratativa em tempo real do código| Comentário do auditor da equipe sobre o erro verificado|
>|----------------|------------|----------------|----------|--------|------------|---------|


#### Gerenciar os Usuários

- Tabela Login - artefato de teste: Controle StaticText (opção Gerenciar os Usuários);
###### Atributos/colunas/variáveis coletadas na tabela
> | Usuario|Idade|Artefato|Clicks|Quantidade de erros| Persistencia do erro| Comentário|
> |-----------|-----|------------|-------|----------|-------------|----------
###### dados coletados na tabela
>| Nome do usuario|Idade do usuário |Artefato testado pelo usuário|Clicks é a quantidade de cliques/ações realizadas pelo usuário sobre o artefato (inputTextSenha)| Número de erros verificados durante o teste| Descrição se o erro persistiu, sim ou não (uma lista de validação) após tratativa em tempo real do código| Comentário do auditor da equipe sobre o erro verificado|
>|----------------|------------|----------------|----------|--------|------------|---------|


## Tipo de validação dos dados

>Os testes dos artefatos para posterior divulgação dos dados coletados só se dará sob a presença de um auditor da equipe. Que ficará responsável em coligir os resultados em tempo real.

## Etapas para cumprimento das atividades

> Cada usuário, fará os teste a fim de recolher os dados para uso no registro de usabilidade, a posteriori. Seguindo as seguintes tarefas que compõe a atividade como um todo:
- O aplicativo deve rodar nos seguintes navegadores: Chrome, Firefox, Edge e Safari;
- Usuário deve estar previamente cadastrado a fim de evitar retrabalho ou confusão na coleta dos dados;
- Auditor deve apenas coletar os dados, eximindo-se de indicar ou participar do como o usuário usa a funcionalidade testada;
- Só haverá melhoria ou ajuste no código do sistema após a conclusão dos testes com todos os usários.

## Coleta dos dados e divulgação

> Os dados coletados após os testes deverão ser reunidos e enviados pelo usuário por email para o auditor. Para formalizar a rastreabilidade do mesmo. Uma vez coletados todos os dados registrados nas tabelas, eles deverão ser consolidados em uma única tabela a fim de serem divulgados em visuais para análise e geração de insights quanto a provaveis mudanças não só em código mas em lógica e dinamica do aplicativo. O que se dará na fase de Registro dos Teste de Usabilidade
