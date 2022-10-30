# Registro de Testes de Usabilidade [RTU]

> Os dados coletados no **Plano de Testes de Usabilidade [PTU]** foram agrupados e tabulados em uma tabela mestre, cujos dados serão divulgados para análise em uma ferramenta de Business Intelligence [BI]. Cada tabulação está vinculada ao **Requisito Funcional [RF]** tratado no PTU, por exemplo: tela de login, tela de criação de Ordens de Serviço [OS's] e assim sucessivamente. Abaixo seguem as etapas de consolidação daqueles dados para sua divulgação, documentação e registro:


## Tabela de consolidação dos dados advindos do PTU
> Os dados coletados durante o PTU foram consolidados em uma única tabela mestre, da qual se fez as tratativas de **Extração, Transformação e Carregamento** daqueles dados para posterior modelagem estatística:

### Tabela Mestre

![TbMeste](https://user-images.githubusercontent.com/36858665/198893402-17c217b4-b7db-4752-a1e3-52c0c88027b2.PNG)

> Na figura acima temos o modelo dimensional dos dados obtidos do PTU: com as devidas variáveis, além de novas como **Faixa Etária, Tipo de Persistência e Erros Comentados**. Esses são detalhados abaixo:

- Faixa Etária: essa variável, que surge durante o processo de modelagem estatística, serve para apontar desvios vinculados ao grupo de idade do usuário;
- Tipo de persistência: essa variável, que surge durante o processo de modelagem estatística, serve para agrupar os tipos de erros/falhas identificadas pelos usuários durante os testes no aplicativo. Possibilitando uma resposta mais imediata e precisa sobre o problema apresentado;
- Erros comentados: essa variável, que surge durante o processo de modelagem estatística, serve para por em evidencia os não erros dos artefatos-chaves testados.

## RTU Geral dos RF-001..RF-003 (detalhes devem ser lidos no PTU)

![ModeloPUC_page-0001](https://user-images.githubusercontent.com/36858665/198895147-a0173724-f3a5-4b5c-8e38-282282e47058.jpg)
> Da leitura dos dados divulgados acima, é possível fazer as seguintes inferências:
- A taxa de erros que persistiram, que, portanto, são erros de design do próprio aplicativo, obrigará a equipe de desenvolvimento a um retrabalho excessivo;
- Quase o dobro dos erros foram apontados por um grupo etário de maior idade. O que pode revelar que os erros não persistentes podem ter surgido tão-somente de um gap de conhecimento do usuário;
- A tipificação de erro **_Campo não reconhecia o dado inputado_** expõe a necessidade de refazer os tipos de dados **string e integer**;
- Resolvendo-se as tipificações de erros **_Campo não reconhecia o dado inputado_** e **_Problemas na confirmação da data selecionada_** faz com que, pela Princípio de Pareto, 80-20, alcança-se o nivel de serviço desejado para soluções desse ramo de construção.


## Cumprimento das tarefas para a entrega da atividade de testes vinculados ao RF- 001

### Teste do artefato-chave do RF-001: inputTextLogin
> Seguindo-se o PTU da RF-001 foram coletados os dados, resultando no divulgador abaixo:
![ModeloPUC_page-0002](https://user-images.githubusercontent.com/36858665/198896387-8850113e-e4e7-4bb4-a26d-dd6dad1c12a1.jpg)

> Da leitura dos dados divulgados acima, é possível fazer as seguintes inferências:
- A tipificação de Erro do artefato em questão é o responsável pelo alto índice de persistência de erros durante os testes;
- É necessário verificar o porque de um objeto de fácil construção, que pode ser criado via componente, ter apresentado tais erros;
- A taxa de erros por clicks também tem forte desvio na tipificação do artefato.

***

### Teste do artefato-chave do RF-001: inputTextSenha
> Seguindo-se o PTU da RF-001 foram coletados os dados, resultando no divulgador abaixo:
![ModeloPUC_page-0003](https://user-images.githubusercontent.com/36858665/198896788-0631c9ef-6001-49a7-8330-353af6b2ebc0.jpg)


> Da leitura dos dados divulgados acima, é possível fazer as seguintes inferências:
- A tipificação de Erro do artefato em questão é o responsável pelo alto índice de persistência de erros durante os testes;
- É necessário verificar o porque de um objeto de fácil construção, que pode ser criado via componente, ter apresentado tais erros;
- A taxa de erros por clicks também tem forte desvio na tipificação do artefato.

### Registro dos testes do artefato-chave
                              


