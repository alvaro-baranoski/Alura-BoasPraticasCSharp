# Capítulo 2 - Design Patterns

## Artigo Design patterns: Breve introdução aos padrões de projeto
Design patters são soluções típicas para problemas comuns em um projeto de software. Elas podem ser aplicadas independentemente da linguagem. São como plantas pré-projetadas de uma construção, que você pode alterar para se adequar melhor na resolução de um problema recorrente em seu código. Ao contrário de funções e bibliotecas, **não é possível copiá-las direto dentro de um programa**. 

Os principais padrões de projeto foram definidos no livro **Design Patterns: Elements of Reusable Object-Orientend Software**, que separa em três tipos de padrões, sendo esses **padrões criacionais, estruturais e comportamentais**, e foram divididos e agrupados de acordo com a natureza do problema que eles solucionam.

### Tipos de design patterns:

1) Padrões criacionais: estes padrões oferecem diversas alternativas de criação de objetos, o que aumenta a flexibilidade e a reutilização de código. Alguns dos principais padrões desse tipo são:
- Factory
- Prototype
- Builder 

2) Padrões estruturais: Nos mostram como montar objetos e classes em estruturas maiores, sem perder a eficiência e flexibilidade. Alguns dos principais padrões desse tipo são:
- Adapter
- Bridge
- Composite

3) Padrões comportamentais: Nos ajudam a trabalhar melhor com os algoritmos e com a delegação de responsabilidades entre os objetos. Os padrões que se destacam nesse tipo são:
- Chain of responsability
- Command
- Interpreter

Referências: \
<https://www.alura.com.br/artigos/design-patterns-introducao-padroes-projeto> \
<https://www.youtube.com/watch?v=tv-_1er1mWI> 

## Design Patterns em C#

### Aula 1
Um padrão de projeto nada mais é do que uma solução elegante para um problema que é muito recorrente em nosso dia-a-dia.

Quando utilizamos uma hierarquia, como fizemos com a interface `Imposto` e as implementações `ICMS` e `ISS`, e recebemos o tipo mais genérico como parâmetro, para ganharmos o polimorfismo na regra que será executada, simplificando o código e sua evolução, estamos usando o Design Pattern chamado **Strategy**.

Repare que a criação de uma nova estratégia de cálculo de imposto não implica em mudanças no código escrito acima! Basta criarmos uma nova classe que implementa a interface `Imposto`, que nosso `CalculadorDeImpostos` conseguirá calculá-lo sem precisar de nenhuma alteração!

O padrão Strategy é muito útil quando temos um conjunto de algoritmos similares, e precisamos alternar entre eles em diferentes pedaços da aplicação. No exemplo do vídeo, temos diferentes maneira de calcular o imposto, e precisamos alternar entre elas.

O Strategy nos oferece uma maneira flexível para escrever diversos algoritmos diferentes, e de passar esses algoritmos para classes clientes que precisam deles. Esses clientes desconhecem qual é o algoritmo "real" que está sendo executado, e apenas manda o algoritmo rodar. Isso faz com que o código da classe cliente fique bastante desacoplado das implementações concretas de algoritmos, possibilitando assim com que esse cliente consiga trabalhar com N diferentes algoritmos sem precisar alterar o seu código.
