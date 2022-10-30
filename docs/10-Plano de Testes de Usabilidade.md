# Plano de Testes de Usabilidade

>O objetivo desse teste é receber o feedback do usuário, certificando-se se o site entrega o esperado e funciona corretamente. Serão 5 (cinco) participantes. 

- O procedimento no qual conduziremos o teste será remotamente via acesso de nosso ambiente sandbox;
- O método escolhido será por avaliação, o usuário nos informará sua experiência com o aplicativo em artefatos-chave.

>Criamos 3 (tres) atividades a serem cumpridas pelos candidatos, as quais estão ligadas aos 3 (tres) requisitos críticos funcionais **[RF]** abaixo descritos:     

## Objetivo 

> Decidiu-se no plano de usabilidade dar foco a controles-chave (críticos) para a interface do aplicativo. E nos quais haja maior possibilidade tanto de erro de programação quanto de intuitivade no uso para o usuário final, como se segue abaixo:


|ID    | Descrição do Requisito  | Objetivo|
|------|---------------------------------------------------------------------------|---------------------------------------------|
|RF-001| A aplicação deverá apresentar uma tela onde o usuário poderá fazer login com "Email" e "Senha". | Verificar se os campos senha e login estão codificados de maneira a rotear corretamente o usuário para a tela determinada, além de ser claro seu uso: se cliente, criação das OS's, se administrador, para a tela de gestão das OS's |
|RF-002| A aplicação deverá apresentar uma tela onde o cliente poderá fazer a solicitação de OS. Com campos para informar o escopo da requisição tais como: descrição, tipo, data e hora desejada para realização da demanda. | Verificar se o controle de seleção de data esta codificado corretamente e intuitivo |
|RF-003| A aplicação deverá exibir uma tela de controle das solicitações feitas, a fim de poder alterar, editar, excluir e criar ordens de serviço  |  Verificar se o controle de conclusão da OS esta corretamente codificado



## Tipo de Coletor de Dado

> Ao liberar o acesso ao ambiente sandbox, cada usuário recebeu um modelo de arquivo ".docx", do Microsoft Word, previamente populado com as seguintes tabelas, agrupadas por requisito, da seguinte forma: RF/Artefato de teste. 

#### Efetuar Login

- Tabela Login - artefato de teste: Controle inputTextSenha (campo senha);
###### Atributos/colunas/variáveis coletadas na tabela
> | Usuario|Idade|Artefato|Clicks|Quantidade de erros| Persistencia do erro| Comentário|
> |-----------|-----|------------|-------|----------|-------------|----------
###### dados coletados na tabela
>| Nome do usuario|Idade do usuário |Artefato testado pelo usuário|Clicks/Ações realizadas pelo usuário sobre o artefato (inputTextSenha)| Número de erros verificados durante o teste| Descrição se o erro persistiu, sim ou não (uma lista de validação) após tratativa em tempo real do código| Comentário do auditor da equipe sobre o erro verificado|
>|----------------|------------|----------------|----------|--------|------------|---------|

***
- Tabela Login - artefato de teste: Controle inputTextLogin (campo login).
> | Usuario|Idade|Artefato|Clicks|Quantidade de erros| Persistencia do erro| Comentário|
> |-----------|-----|------------|-------|----------|-------------|----------
###### dados coletados na tabela
>| Nome do usuario|Idade do usuário |Artefato testado pelo usuário|Clicks/Ações realizadas pelo usuário sobre o artefato (inputTextLogi)| Número de erros verificados durante o teste| Descrição se o erro persistiu, sim ou não (uma lista de validação) após tratativa em tempo real do código| Comentário do auditor da equipe sobre o erro verificado|
>|----------------|------------|----------------|----------|--------|------------|---------|

#### Criar OS's

- Tabela Criar Login - artefato de teste: Controle datePicker (campo seleção de data desejada de execução da OS).
> | Usuario|Idade|Artefato|Clicks|Quantidade de erros| Persistencia do erro| Comentário|
> |-----------|-----|------------|-------|----------|-------------|----------
###### dados coletados na tabela
>| Nome do usuario|Idade do usuário |Artefato testado pelo usuário|Clicks/Ações realizadas pelo usuário sobre o artefato (datePicker)| Número de erros verificados durante o teste| Descrição se o erro persistiu, sim ou não (uma lista de validação) após tratativa em tempo real do código| Comentário do auditor da equipe sobre o erro verificado|
>|----------------|------------|----------------|----------|--------|------------|---------|


#### Gestão da OS

- Tabela Gestão de OS - artefato de teste: Controle checkBox (campo de "feito", conclusão da tratativa da OS)
> | Usuario|Idade|Artefato|Clicks|Quantidade de erros| Persistencia do erro| Comentário|
> |-----------|-----|------------|-------|----------|-------------|----------
###### dados coletados na tabela
>| Nome do usuario|Idade do usuário |Artefato testado pelo usuário|Clicks/Ações realizadas pelo usuário sobre o artefato (checkBox)| Número de erros verificados durante o teste| Descrição se o erro persistiu, sim ou não (uma lista de validação) após tratativa em tempo real do código| Comentário do auditor da equipe sobre o erro verificado|
>|----------------|------------|----------------|----------|--------|------------|---------|

## Tipo de validação dos dados

>Os testes para posterior registro dos mesmos só se dará sob a presença de um auditor da equipe. Que ficará responsável em captar os resultados em tempo real.

## Atividades

> Cada usuário, fará os teste a fim de recolher os dados para uso no registro de funcionalidade, a posteriori. Seguindo as seguintes tarefas que compõe a atividade como um todo:
- O aplicativo deve rodar nos seguintes navegadores: Chrome, Firefox, Edge e Safari;
- Usuário deve estar previamente cadastrado a fim de evitar retrabalho ou confusão na coleta dos dados;
- Auditor deve apenas coletar os dados, eximindo-se de indicar ou participar do como o usuário usa a funcionalidade testada;
- Só haverá melhoria ou ajuste no código do sistema após a conclusão dos testes com todos os usários.

