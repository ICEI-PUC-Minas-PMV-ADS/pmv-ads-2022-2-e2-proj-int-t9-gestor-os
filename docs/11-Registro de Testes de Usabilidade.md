# Registro de Testes de Usabilidade [RTU]

> Os dados coletados no **Plano de Testes de Usabilidade [PTU]** foram agrupados e tabulados em uma tabela mestre, cujos dados serão divulgados para análise em uma ferramenta de Business Intelligence [BI]. Cada tabulação está vinculada ao **Requisito Funcional [RF]** tratado no PTU, por exemplo: tela de login, tela de criação de Ordens de Serviço [OS's] e assim sucessivamente. Abaixo seguem as etapas de consolidação daqueles dados para sua divulgação, documentação e registro:


## Tabela de consolidação dos dados advindos do PTU
> Os dados coletados durante o PTU foram consolidados em uma única tabela mestre, da qual se fez as tratativas de **Extração, Transformação e Carregamento** daqueles dados para posterior modelagem estatística:

### Tabela Mestre

![TbMeste](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t9-gestor-os/blob/main/Imgs/tabelatesters.jpg?raw=true)

> Na figura acima temos o modelo dimensional dos dados obtidos do PTU: com as devidas variáveis, além de novas como **Faixa Etária, Tipo de Persistência e Erros Comentados**. Esses são detalhados abaixo:

- Faixa Etária: essa variável, que surge durante o processo de modelagem estatística, serve para apontar desvios vinculados ao grupo de idade do usuário;
- Tipo de persistência: essa variável, que surge durante o processo de modelagem estatística, serve para agrupar os tipos de erros/falhas identificadas pelos usuários durante os testes no aplicativo. Possibilitando uma resposta mais imediata e precisa sobre o problema apresentado;
- Erros comentados: essa variável, que surge durante o processo de modelagem estatística, serve para por em evidencia os não erros dos artefatos-chaves testados.

## RTU Geral dos RF-001..RF-005 (detalhes devem ser lidos no PTU)

![ModeloPUC_page-0001](https://user-images.githubusercontent.com/36858665/198895147-a0173724-f3a5-4b5c-8e38-282282e47058.jpg)
> Da leitura dos dados divulgados acima, é possível fazer as seguintes inferências:
- A taxa de erros que persistiram, que, portanto, são erros de design do próprio aplicativo, obrigará a equipe de desenvolvimento a um retrabalho excessivo;
- Quase o dobro dos erros foram apontados por um grupo etário de maior idade. O que pode revelar que os erros não persistentes podem ter surgido tão-somente de um gap de conhecimento do usuário;
- A tipificação de erro **_Campo não reconhecia o dado inputado_** expõe a necessidade de refazer os tipos de dados **string e integer**;
- Resolvendo-se as tipificações de erros **_Campo não reconhecia o dado inputado_** e **_Problemas na confirmação da data selecionada_** faz com que, pela Princípio de Pareto, 80-20, alcança-se o nivel de serviço desejado para soluções desse ramo de construção.


## Cumprimento das tarefas para a entrega da atividade de testes vinculados ao RF- 001

### Teste do artefato-chave do RF-001: inputTextLogin
> Seguindo-se o PTU da RF-001 foram coletados os devidos dados, resultando no divulgador abaixo:
![ModeloPUC_page-0002](https://user-images.githubusercontent.com/36858665/198896387-8850113e-e4e7-4bb4-a26d-dd6dad1c12a1.jpg)

> Da leitura dos dados divulgados acima, é possível fazer as seguintes inferências:
- A tipificação de Erro do artefato em questão é o responsável pelo alto índice de persistência de erros durante os testes;
- É necessário verificar o porque de um objeto de fácil construção, que pode ser criado via componente, ter apresentado tais erros;
- A taxa de erros por clicks também tem forte desvio na tipificação do artefato.

***

### Teste do artefato-chave do RF-001: inputTextSenha
> Seguindo-se o PTU da RF-001 foram coletados os devidos dados, resultando no divulgador abaixo:
![ModeloPUC_page-0003](https://user-images.githubusercontent.com/36858665/198896788-0631c9ef-6001-49a7-8330-353af6b2ebc0.jpg)


> Da leitura dos dados divulgados acima, é possível fazer as seguintes inferências:
- A tipificação de Erro do artefato em questão é o responsável pelo alto índice de persistência de erros durante os testes;
- É necessário verificar o porque de um objeto de fácil construção, que pode ser criado via componente, ter apresentado tais erros;
- A taxa de erros por clicks também tem forte desvio na tipificação do artefato.

## Cumprimento das tarefas para a entrega da atividade de testes vinculados ao RF- 002

### Teste do artefato-chave do RF-002: datePicker
> Seguindo-se o PTU da RF-002 foram coletados os devidos dados, resultando no divulgador abaixo:

![ModeloPUC_page-0004](https://user-images.githubusercontent.com/36858665/198897075-9fdf344c-44da-4e7f-b33e-44a0390582c5.jpg)

> Da leitura dos dados divulgados acima, é possível fazer as seguintes inferências:
- A tipificação de Erro do artefato em questão é a que mais desvia em relação a má abordagem de treinamento. Já que é a que tem maior persistencia vinculada a erro por falta de conhecimento do usuário;
- É necessário verificar uma forma de notificar o usuário, durante a seleção da data de desejo de execução da **Orden de Serviço [OS]**, que a ação só será um sucesso no momento que ele confirma a seleção;
- A leitura também nos diz que sanado o problema com este controle faz com que o RF-002 seja plenamente satisfeito.


### Teste do artefato-chave do RF-003: checkBox
> Seguindo-se o PTU da RF-003 foram coletados os devidos dados, resultando no divulgador abaixo:
![ModeloPUC_page-0005](https://user-images.githubusercontent.com/36858665/198897333-8e657320-d814-4cad-bf87-3d46732e09d4.jpg)
> Da leitura dos dados divulgados acima, é possível fazer as seguintes inferências:
- A tipificação de Erro do artefato em questão é a única que apresenta falha em eventos da propriedade **reset**;
- É a segunda tipificação a desviar para cima o erro de confirmação de persistencia.


### Teste do artefato-chave do RF-004: searchBox
> Seguindo-se o PTU da RF-004 foram coletados os devidos dados, resultando no divulgador abaixo:
![ModeloPUC_page-0005](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t9-gestor-os/blob/main/Imgs/searchboox.jpg?raw=true)
> Da leitura dos dados divulgados acima, é possível fazer a seguinte inferência:
- Não foi encontrado erro.


### Teste do artefato-chave do RF-005: staticText
> Seguindo-se o PTU da RF-005 foram coletados os devidos dados, resultando no divulgador abaixo:
![ModeloPUC_page-0005](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e2-proj-int-t9-gestor-os/blob/main/Imgs/statictext.jpg?raw=true)
> Da leitura dos dados divulgados acima, é possível fazer a seguinte inferência:
- Não foi encontrado erro.

## Comentários e Conclusão
> O RTU seguiu à risca o PTU. Trazendo à baila todos as etapas das tarefas para se cumprirem as ativades do escopo proposto. Dando enfase as RFs a fim de testar apenas os artefatos mais críticos na visão da equipe de desenvolvimento. 
> Claramente, melhorias serão necessárias assim como destacar novas formas de entregas em menores espaço de tempo a fim de coletar feedbacks mais curtos dos usuários.

> Da análise do RTU foram levantadas as seguintes melhorias de design:
- Criação de ramo de teste para rever as funcionalidades que desviaram no teste de persistencia;
- Melhoria dos estilos em CSS para evitar que o usuário não consiga entender se o campo está ativo ou não;
- Nova compilação dos controles do tipo InputText a fim de sanar o problema dos desvio de persistencia;
- Vincular novas opções de alertas e notificações que indiquem aos usuários os passos corretos a percorrerem nos controle de data da solução.



