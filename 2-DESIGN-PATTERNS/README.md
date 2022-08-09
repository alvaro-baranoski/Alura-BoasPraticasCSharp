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

### Aula 2
Agora que implementamos o **Chain of Responsibility**, temos cada uma das responsabilidades separadas em uma classe, e uma forma de unir essa corrente novamente. Veja a flexibilidade que o padrão nos deu: podemos montar a corrente da forma como quisermos, e sem muitas complicações.

O padrão Chain of Responsibility cai como uma luva quando temos uma lista de comandos a serem executados de acordo com algum cenário em específico, e sabemos também qual o próximo cenário que deve ser validado, caso o anterior não satisfaça a condição.

Nesses casos, o Chain of Responsibility nos possibilita a separação de responsabilidades em classes pequenas e enxutas, e ainda provê uma maneira flexível e desacoplada de juntar esses comportamentos novamente.

### Aula 3
Utilização de **Template Method**, que se baseia em criar uma classe abstrata que é usada como padrão para as outras classes que as herdam, mudando apenas as "lacunas" dos métodos abstratos. Dessa forma, é possível escrever menos código.

Quando temos diferentes algoritmos que possuem estruturas parecidas, o Template Method é uma boa solução. Com ele, conseguimos definir, em um nível mais macro, a estrutura do algoritmo e deixar "buracos", que serão implementados de maneira diferente por cada uma das implementações específicas.

Dessa forma, reutilizamos ao invés de repetirmos código, e facilitamos possíveis evoluções, tanto do algoritmo em sua estrutura macro, quanto dos detalhes do algoritmo, já que cada classe tem sua responsabilidade bem separada.

### Aula 4
Quando compomos comportamento, através de classes que recebem objetos do mesmo tipo que elas mesmas (nesse caso, ISS que é um Imposto, recebe em seu construtor outro Imposto) para fazerem parte de seu comportamento, de uma maneira que seu uso é definido a partir do que se passou para a instanciação dos objetos, é o que caracteriza o Design Pattern chamado **Decorator**.

Sempre que percebemos que temos comportamentos que podem ser compostos por comportamentos de outras classes envolvidas em uma mesma hierarquia, como foi o caso dos impostos, que podem ser composto por outros impostos. O Decorator introduz a flexibilidade na composição desses comportamentos, bastando escolher no momento da instanciação, quais instancias serão utilizadas para realizar o trabalho.

### Aula 5
O **State** é um design pattern utilizado quando a aplicação possui muitos estados que possuem certas regras de negócio, e esses estados tem uma ordem de transição que deve ser seguida (no caso do exemplo, em aprovação -> aprovado/reprovado -> finalizado).

A principal situação que faz emergir o Design Pattern State é a necessidade de implementação de uma máquina de estados. Geralmente, o controle das possíveis transições são vários e complexos, fazendo com que a implementação não seja simples. O State auxilia a manter o controle dos estados simples e organizados através da criação de classes que representem cada estado e saiba controlar as transições.

### Aula 06
O padrão **Builder** é utilizado quando se tem uma classe que possui muitos atributos que precisam ser repassados através de um construtor. Ele permite que o programa cliente utilize um encadeamento de métodos para repassar todos os atributos (similar a setters, pode esconder regras de negócio), e ao final, tem o método `build` que permite gerar o objeto final.

Sempre que tivermos um objeto complexo de ser criado, que possui diversos atributos, ou que possui uma lógica de criação complicada, podemos esconder tudo isso em um Builder.

Além de centralizar o código de criação e facilitar a manutenção, ainda facilitamos a vida das classes que precisam criar essa classe complexa, afinal a interface do Builder tende a ser mais clara e fácil de ser usada.

### Aula 07
Esta aula é sobre o padrão de projeto **Observer**. Este padrão tem por objetivo notificar ou executar a ação de alguma classe toda vez que alguma coisa específica acontece dentro do programa. Ele funciona considerando que todas as classes observadores utilizam o mesmo método (baseado em uma interface) e que este método é executado através de um for loop dentro do método que gera o evento.

O Observer desacopla seu código e possibilita que seu código execute diferentes ações após algum evento. Além disso, como o código acima demonstra, criar e executar novas ações é uma tarefa fácil agora, facilitando a manutenção e evolução desse trecho de código.

No exemplo, os eventos eram repassados através do método `adicionaEvento`, mas também é possível repassar essa lista de eventos pelo construtor.

Podemos utilizar o Observer quando o acoplamento da nossa classe está crescendo, ou quando temos diversas ações diferentes a serem executadas após um determinado processo.

Ele permite que diversas ações sejam executadas de forma transparente à classe principal, reduzindo o acoplamento entre essas ações, facilitando a manutenção e evolução do código.
