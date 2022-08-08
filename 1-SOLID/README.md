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