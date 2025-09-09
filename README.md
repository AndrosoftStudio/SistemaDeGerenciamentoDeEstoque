Sistema de Gerenciamento de Estoque
Um sistema de console simples e interativo para gerenciar produtos e seus respectivos tipos, desenvolvido em C#.

📜 Descrição
Este projeto é uma aplicação de console criada para demonstrar os conceitos básicos de programação orientada a objetos em C#. Ele permite que o usuário cadastre tipos de produtos e, em seguida, cadastre produtos que pertencem a esses tipos. Todos os dados são armazenados em memória durante a execução do programa.

✨ Funcionalidades
Gestão de Tipos de Produto:

Criação de novos tipos com nome e descrição.

Geração de um ID único para cada tipo.

Gestão de Produtos:

Criação de novos produtos com nome e descrição.

Associação obrigatória de um produto a um tipo já existente.

Geração de um ID único para cada produto.

Listagem de Dados:

Exibe uma lista formatada de todos os produtos cadastrados.

Menu Interativo:

Navegação simples e intuitiva através de um menu no console.

Seção de ajuda para esclarecer o funcionamento das principais funcionalidades.

🚀 Como Executar o Projeto
Para compilar e executar este projeto, você precisará ter o SDK do .NET instalado em sua máquina.

Clone o repositório:

git clone [https://github.com/AndrosoftStudio/SistemaDeGerenciamentoDeEstoque.git](https://github.com/AndrosoftStudio/SistemaDeGerenciamentoDeEstoque.git)

Navegue até o diretório do projeto:

cd SistemaDeGerenciamentoDeEstoque

Execute o projeto:

dotnet run

Siga as instruções do Menu:

Ao iniciar, o menu principal será exibido.

Importante: Você deve primeiro cadastrar um Tipo (opção [2]) antes de poder cadastrar um Produto (opção [1]).

=====================================================
                  BEM VINDO AO MENU
=====================================================
                    LISTA DE AÇÕES
-----------------------------------------------------
[1] Cadastrar novo Produto
[2] Cadastrar novo Tipo
[3] Imprimir Produtos
[?] Caso Tenha Duvidas...
[0] Fechar o Programa...
-----------------------------------------------------

🛠️ Tecnologias Utilizadas
C#: Linguagem de programação principal.

.NET: Plataforma de desenvolvimento.

🏛️ Estrutura do Código
O projeto está organizado nas seguintes classes principais:

Program.cs: Contém a lógica principal do programa, incluindo o Main, o menu e as funções para criar e listar os itens.

Produto: Classe que representa o modelo de um produto (ID, nome, descrição, tipo).

Tipo: Classe que representa o modelo de um tipo de produto (ID, nome, descrição).

OperationsSystem: Classe responsável por gerenciar a lógica de navegação do menu e das opções de ajuda.

HelpQuerys: Contém os textos de ajuda exibidos ao usuário.

Aleatorios: Classe utilitária para gerar números aleatórios.

✒️ Autor
Androsoft Studio - AndrosoftStudio
