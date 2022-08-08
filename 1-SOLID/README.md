# Curso Alura - SOLID com C#: princípios da programação orientada a objetos

O projeto é um sistema de administração de leilões.

## 01. Qualidade de software

O que é um software de qualidade? É um software que se mostra pronto para mudanças (é possível fazer mudanças sem muito sofrimento)!

Conceito de divida técnica:

> Shipping first time code is like going into dept. A little speeds development so long as it is paid back promptly with a rewrite... The danger occurs when this dept is not repaid. Every minute spent on not-quite-right code counts as interest on that dept. Entire engineering organizations can be brought to a stand-still under dept load of an unconsolidated implementation, object-oriented or othrewise.
> -- <cite>Benjamin Franklin</cite>

[Página de referência da wiki](https://en.wikipedia.org/wiki/Technical_debt).
[Vídeo do Ward Cunningham](https://www.youtube.com/watch?v=pqeJFYwnkjE).

Conceito de code smells:

Forma de identificar códigos de má qualidade, e serve como forma de correção para pagar dívidas técnicas (um exemplo é muito código repetido).

Artigo sobre code smells:
<https://www.martinfowler.com/bliki/CodeSmell.html>

Lista de code smells tipicos para referência:
- <https://refactoring.guru/refactoring/smells>
- <https://blog.codinghorror.com/code-smells/>
- <https://blog.jetbrains.com/dotnet/2018/06/18/sharpen-sense-code-smell/>

Graças a experiências de outros devs, foram gerados **patterns** de desenvolvimento a serem seguidos, e também princípios de desenvolvimento, como é o caso do **SOLID**.

## 02. Responsabilidade única (_single responsability principle_)

Em .NET, é interessante separar os métodos de CRUD de acesso a base de dados em uma classe especializada, no exemplo o professor criou uma classe `LeilaoDao` (DAO vem de _data access object_).

O objetivo de realizar essa refatoração (extrair as funcionalidades para uma classe específica) é para que, caso seja necessário alterar alguma funcionalidade destas operações, só seja necessário alterar em um único lugar.

Para realizar esse tipo de refatoração, é necessário utilizar o princípio DRY - Dont Repeat Yourself.

Métodos e classes devem ter uma **única responsabilidade**, ou seja, devem ser métodos coesos, de poucas linhas de código, que realizam apenas uma função. Classes devem ser criadas para atender a uma determinada demanda, e devem atender os **agentes de mudança**.

Single Source of Truth: Se o código estiver bem coeso, cada parte irá possuir apenas uma responsabilidade, e apenas essa parte irá conte-la.

> Gather together the things that change for the same reasons. Separate those things that change for different reasons.

Artigo sobre o single responsability principle (SRP): <https://blog.cleancoder.com/uncle-bob/2014/05/08/SingleReponsibilityPrinciple.html>.

## 03. Inversão de dependências (_Dependency Inversion Principle_)

Uma classe pode depender de classes **instáveis** e **estáveis**. Classes estáveis são aquelas que dificilmente irão mudar, como é o caso do tipo `int` ou a classe `Controller` do framework .NET. Classes estáveis, por outro lado, tendem a ter seu comportamento alterado pelo programador, como é o caso das classes `Leilao` e `LeilaoDao`.

`LeilaoDao` é mais instável do que `Leilao`, pois ela também depende de outros tipos que são instáveis, como `Categoria` e `AppDbContext`. O que o professor recomendou é renomear a classe para `LeilaoDaoComEfCore` para indicar a dependência, e criar uma interface `ILeilaoDao`.

Da forma como está o código, `LeilaoController` depende de `LeilaoDaoComEfCore`, que é instável:

```
ILeilaoDao _dao;

public LeilaoController()
{
    _dao = new LeilaoDaoComEfCore();
}
```

Para corrigir essa dependência, o .NET possui a função de injeção de dependência, da seguinte forma:
Em `LeilaoController`:
```
ILeilaoDao _dao;

public LeilaoController(ILeilaoDao dao)
{
    _dao = dao;
}
```

E em `Program.cs`:
```
services.AddTransient<ILeilaoDao, LeilaoDaoComEfCore>();
```

Essas refatorações pertencem ao conceito de _Dependency Inversion Principle_ (DIP). Uma das formas de exercer esse conceito é através da **injeção de dependencias**, onde fornecemos uma abstração de nossas dependências, deixando a responsabilidade para quem instancia a classe, dessa forma também estamos explicitando as dependências de uma classe através de seu construtor. Quando a classe dependente deixa de resolver as dependências diretamente e cede esse controle para outrém temos o uso do conceito **Inversão de Controle** (IoC).

## 04. Princípio do Aberto/Fechado (_Open-closed Principle_)
Princípio que diz para manter a sua aplicação fechada para mudanças, mas aberta para extensões. Diz basicamente para criar o hábito de minimizar a alteração de código pronto. Se for necessário fazer uma alteração, é melhor criar uma outra classe que aplica essa mudança. Para os trechos de código que continuam os mesmos, o correto é utilizar **decorators** para repassar a implementação que não foi alterada para a classe antiga.

Esse princípio visa manter a estabilidade de classes já criadas.

Nessa aula, o professor também mostrou a utilização de _Service Layers_, uma camada arquitetural que separa as regras de negócio das camadas mais externas (interfaces de usuário, integração com outros sistemas, etc). 

Artigo sobre o pattern de camada de serviços: <https://martinfowler.com/eaaCatalog/serviceLayer.html>

Artigo sobre o open-closed principle pelo criador do SOLID: <https://blog.cleancoder.com/uncle-bob/2014/05/12/TheOpenClosedPrinciple.html>

Artigo sobre o pattern de utilização de decorators: <https://en.wikipedia.org/wiki/Decorator_pattern>

## 05. Segregação de Interfaces e Liskov (_Interface Segregation Principle_ e _Liskov Substitution Principle_)

Princípio da segregação de interfaces: Interfaces também precisam se preocupar com coesão e acoplamento (LEMBRAR: INTERFACE É DE OOP, NÃO DO FRONTEND).

Pelo princípio da substituição de Liskov (LSP): É preciso cumprir todas as promessas que as abstrações (interfaces e classes abstratas) propõe.

No exemplo o professor criou uma interface `IDao` para padronizar os nomes dos métodos implementados pelos serviços. Esta interface tinha a promessa de métodos de leitura e escrita. Porém, o service de categoria não tinha como regra de negócio a realização de escrita de novas categorias. Portanto, foi necessário segregar a interface em duas, `ICommand` para escrita e `IQuery` para leitura, de forma que os serviços herdavam apenas as interfaces que realmente iriam implementar (ou cumprir a sua promessa). 