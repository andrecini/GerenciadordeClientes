# GerenciadordeClientes
Teste para a SmartHint

## Requisitos
- **Linguagem:** .Net ou .Net Core
- **Banco de dados:** MYSQL
- **Tempo para a entrega do Projeto:** 4 dias
  
## Disponibilização do Projeto
- Desenvolver o projeto e disponibilizar no GitHub
- Disponibilização de todos o fonte do projeto
- Disponibilização do script de criação das Tabelas

## O que deve ser desenvolvido
O projeto deverá ser desenvolvido de acordo com as especificações abaixo:

### Listagem de Compradores
- A tela deverá possuir a seguinte descrição "Consulte os seus Clientes cadastrados na
sua Loja ou realize o cadastro de novos Cliente";
- Ao lado direito da área de descrição, deverá ser apresentado o botão "Adicionar Cliente".
- Quando o Usuário-Lojista selecionar o botão "Filtrar", deverá ser apresentada a área de
pesquisa de Compradores.
- Deverão ser apresentadas as seguintes opções para o Usuário-Lojista:
  
1. **Nome/Razão Social:**
- Campo do tipo input que deverá realizar o filtro considerando o Nome ou Razão
Social dos Compradores;
- Placeholder: Nome ou Razão Social do Cliente.
2. **E-mail:**
- Campo do tipo input que deverá realizar o filtro considerando o e-mail cadastrado
para os Compradores;
- Placeholder: E-mail do Cliente.
3. **Telefone:**
- Campo do tipo input que deverá realizar o filtro considerando o telefone cadastrado
para os Compradores;
- Placeholder: Telefone do Cliente
4. **Data de Cadastro:**
- Campo do tipo date picker que deverá realizar o filtro considerando a Data de
Cadastro do Comprador;
- Placeholder: Selecione uma data ou período.
5. **Cliente bloqueado:**
- Campo do tipo combobox que deverá retornar às opções SIM e NÃO e deverá
realizar o filtro considerando se os Compradores estão bloqueados ou não.

- Quando o Usuário-Lojista selecionar o botão "Limpar filtros", todos os dados
inseridos/selecionados deverão ser limpos;
- Quando o Usuário-Lojista selecionar o botão "Aplicar filtros", deverá ser realizado o filtro
no grid de acordo com os dados inseridos/selecionados;
- Quando o filtro for aplicado, a área de filtros deverá ser fechada;
- O Usuário-Lojista poderá retirar um filtro selecionando o botão de deleção do filtro,
quando este cenário ocorrer, uma nova pesquisa deverá ser realizada entre os Clientes;
- Abaixo da descrição, deverá ser exibido um grid com todos os Compradores cadastrados
na Loja, este que deverá possuir as seguintes colunas:

1. **Checkbox**
- Quando o Usuário-Lojista selecionar o checkbox do cabeçalho do grid,
todos os Compradores deverão ser selecionados, caso ele selecione em uma linha,
somente o Comprador da linha deverá ser selecionado;
3. **Nome/Razão Social**
- Deverá ser retornado o Nome do Comprador, em caso de um
Comprador do tipo Pessoa Física e a Razão Social do Comprador, em caso de um
Comprador do tipo Pessoa Jurídica;
4. **E-mail**
- Deverá ser retornado o e-mail cadastrado para o Comprador;
5. **Telefone**
- Deverá ser retornado o telefone cadastrado para o Comprador;
6. **Data de cadastro**
- Deverá ser retornada a data de cadastro do Comprador, este que
deverá seguir o padrão DD/MM/AAAA;
7. **Bloqueado**
- Coluna do tipo checkbox que poderá ser editada pelo Usuário-Lojista e
informará se o Comprador está ou não bloqueado;
8. **Ações**
- Deverá ser apresentado o botão de edição para os Compradores.
- Quando o Usuário-Lojista selecionar o botão de edição, o mesmo deverá ser
redirecionado para a tela de Edição do Comprador selecionado;

- Abaixo do grid, deverá ser apresentada o pagination;
- Deverão retornar 20 (vinte) compradores por página.
Cadastro de Clientes
- Quando o Usuário-Lojista selecionar o botão Adicionar Cliente, deverá ser direcionado
para a tela de Adicionar Cliente.
- Caso o Usuário-Lojista selecione o botão "Voltar", o mesmo deverá ser redirecionado
para a tela de Clientes;
- Na área principal do cadastro, deverão ser apresentados os seguintes campos:

1. **Nome do Cliente/Razão Social:**
- Campo obrigatório do tipo input que deverá receber caracteres alfa-numéricos
com no máximo 150 (cento e cinquenta) caracteres;
- Tooltip: Nome completo ou Razão Social do Cliente.

2. **E-Mail:**
- Campo obrigatório do tipo input que deverá receber caracteres alfa-numéricos
com no máximo 150 (cento e cinquenta) caracteres, o campo deverá possuir a
validação se o dado inserido é um e-mail;
- Tooltip: E-mail do Cliente.

3. **Telefone:**
- Campo obrigatório do tipo input que deverá receber caracteres numéricos com no
máximo 11 (onze) caracteres, o campo deverá possuir a máscara de telefone “(##)
#####-####;
- Tooltip: Telefone do Cliente.

4. **Data de Cadastro:**
- Campo que deverá retornar a data atual.

Abaixo da área principal, deverá ser apresentada a área de Informações Pessoais, esta
que deverá possuir os seguintes campos:

5. **Tipo de Pessoa:**
- Campo obrigatório do tipo combobox, que deverá retornar as opções Física e
Jurídica;
- Tooltip: Selecione o tipo de Pessoa.

6. **CPF/CNPJ:**
- Campo obrigatório do tipo input que deverá receber caracteres numéricos com no
máximo 14 (quatorze) caracteres, o campo deverá possuir a máscara de CPF
###.###.###-## para quando forem inseridos 11 (onze) caracteres e a máscara de
CNPJ "##.###.###/####-##" para quando forem inseridos mais caracteres;
- Tooltip: Insira o CPF ou o CNPJ do Cliente.

7. **Inscrição Estadual:**
- Campo obrigatório para o tipo de Pessoa Jurídica ou para ambos quando a
configuração "Inscrição estadual para Pessoa Física" estiver ativo, do tipo input que
deverá receber caracteres numéricos com no máximo 12 (doze) caracteres, o
campo deverá possuir a máscara ###.###.###-###;
- Tooltip: Inscrição Estadual do Cliente, selecionar Isento caso assim for.

8. **Isento:**
- Campo do tipo Checkbox, caso seja selecionado, a Inscrição Estadual estará
isenta. O campo Inscrição Estadual será bloqueado quando selecionado.

Os campos abaixo só deverão ser apresentados quando for selecionado o tipo de pessoa
Física:

9. **Gênero:**
- Campo obrigatório do tipo combobox, que deverá retornar as opções Feminino,
Masculino e Outro;
- Tooltip: Selecione o gênero do Cliente.

10. **Data de Nascimento:**
- Campo obrigatório do tipo date;
- Tooltip: Data de nascimento do Cliente.

A área de Situação do Cliente deverá possuir os seguintes campos:

11. **Bloqueado:**
- Campo do tipo checkbox;
- Tooltip: Bloqueio o acesso do Cliente na sua Loja;
- Regra: Quando um Cliente estiver selecionado como Bloqueado, o mesmo não
poderá acessar a Loja.

A área de Senha de Acesso deverá possuir os seguintes campos:
- **Tooltip:** Cadastre a senha de acesso do seu Cliente;
- **Senha:** Campo obrigatório do tipo input que deverá receber caracteres alfanuméricos
com no mínimo 8 (oito) caracteres e no máximo 15 (quinze) caracteres;
- **Confirmação de Senha:** Campo obrigatório do tipo input que deverá receber
caracteres alfanuméricos com no mínimo 8 (oito) caracteres e no máximo 15 (quinze)
caracteres. Deverá ser validado se o valor inserido no campo de confirmação de
senha, é igual ao campo de senha. Caso os dados estejam diferentes, deverá ser
exibido a seguinte mensagem ao Usuário-Lojista “As senhas não conferem”.

- Quando o Usuário-Lojista selecionar o botão "Adicionar Cliente", deverá ser validado se
todos os campos obrigatórios foram inseridos/selecionados;
- Caso algum campo obrigatório não tenha sido inserido/selecionado, deverá ser
apresentada uma mensagem de obrigatoriedade de inserção/seleção do campo e o
Comprador não poderá ser adicionado;
- Deverá ser validado se o e-mail inserido já está cadastrado na base de Compradores da
Loja, caso esteja, deverá ser apresentado um toast informando que o e-mail já está
vinculado a outro Comprador;
- A mensagem a ser apresentada no toast deverá ser "Este e-mail já está cadastrado para
outro Cliente";
- Deverá ser validado se o CPF/CNPJ inserido já está cadastrado na base de
Compradores da Loja, caso esteja, deverá ser apresentado um toast informando que o
CPF/CNPJ já está vinculado a outro Comprador;
- A mensagem a ser apresentada no toast deverá ser "Este CPF/CNPJ já está cadastrado
para outro Cliente";
- Quando o tipo o Comprador for do tipo Pessoa Jurídica ou quando a configuração
"Inscrição estadual para Pessoa Física" estiver ativada e o valor do campo Inscrição
Estadual for diferente de Isento, deverá ser validado se o valor inserido já está
cadastrado na base de Compradores da Loja, caso esteja, deverá ser apresentado um
toast informando que a Inscrição Estadual já está vinculada a outro Comprador;
1. A mensagem a ser apresentada no toast deverá ser "Esta Inscrição Estadual já está
cadastrada para outro Cliente";
2. Caso todos os campos obrigatórios tenham sido inseridos/selecionados, o
Comprador deverá ser criado e o Usuário-Lojista deverá ser redirecionado para a tela de
Clientes.
