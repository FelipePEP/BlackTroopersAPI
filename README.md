# BlackTroopersAPI

Este é um projeto de estudo para aplicar os conceitos apresentados na [arquitetura clean de Uncle Bob](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html) e os recursos de C# ensinados no [curso Advanced Topics de Mosh Hamedani](https://www.udemy.com/course/csharp-advanced). No futuro, este projeto deve servir como Backend para uma aplicação angular tambem criada para fins de estudo e aperfeiçoamento.Se tudo ficar bom, teremos uma aplicação online para Black Troopers.

## O que é Black Troopers?
Black Troopers é um jogo de RPG de mesa beneficente criado por mim e publicado via [financiamento coletivo](https://www.catarse.me/black_troopers). Meu objetivo é prover para aos apoiadores uma aplicação web com conteudos relativos ao jogo.

Conheça mais de Black Troopers [aqui](http://guildadosmestres.com.br/tag/black-troopers/).

## Camadas da Arquitetura

### Domain

Conterá todas as entidades, enums, exceções, interfaces dos casos de uso, tipos e lógica específicos da camada de domínio.

### Application

Conterá toda a lógica dos casos de uso do aplicativo. É dependente da camada de domínio e não possui dependências de nenhuma outra camada. Define interfaces que são implementadas por camadas externas como filas, banco de dados etc.

### Infrastructure

Contém classes para acessar recursos externos, como smtp, banco de dados e assim por diante. Essas classes devem ser baseadas em interfaces definidas na camada de aplicação.

### Presentation

Essa camada é uma API em .NET Core 6. Depende da camada de Infraestrutura, no entanto pode ter dependencias da camada de Aplicação em algum momento posterior.
