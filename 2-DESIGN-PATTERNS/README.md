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

No Strategy estamos tentando implementar uma estratégia diferente para resolver um determinado problema que temos no código. Por exemplo, imagine que a aplicação precisa enviar buscas para diversos bancos de dados diferentes, nesse caso, o código que será executado em cada banco de dados será levemente diferente, mas o propósito é o mesmo: Fazer o acesso aos dados.

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

### Aula 08
Nesta aula foi demonstrado o padrão de projeto **Factory**, que é similar ao Builder, mas que tem por objetivo realizar a criação de objetos complicados dentro de sua classe, deixando essa lógica escondida de outros usuários.

Usamos uma fábrica quando temos que isolar o processo de criação de um objeto em um único lugar. Essa fábrica pode descobrir como criar o objeto dentro dela própria, mas geralmente ela não precisa de muitas informações para criar o objeto.

### Aula 09
O padrão **Flyweight** é utilizado para instanciar objetos uma única vez, e estes objetos então podem ser usados em vários lugares no programa. Uma qualidade deste padrão é que é possível economizar a memória da aplicação, pois dessa forma menos objetos precisam ser instanciados.

Sempre que temos uma quantidade grande de objetos similares a serem instanciados, uma boa solução é fazer cache dessas instâncias e reutilizá-la. Para isso, a implementação é geralmenta fazer uso de uma fábrica, que controla as instâncias. Esse padrão é conhecido por flyweight.

Aplicações gráficas geralmente fazem uso desse padrão, já que elas tem muito objeto repetido.

Outro exemplo são as strings do C#. Quando escrevemos o seguinte código no programa:

`string mensagem = "Minha Mensagem";`

A máquina virtual cria uma referência para um objeto do tipo string e o armazena em memória. Se em outro ponto do código tivermos outra variável do tipo string inicializada com o mesmo texto, a máquina virtual simplesmente reutiliza a mesma instância do objeto.

### Aula 10
Padrão de projeto **Memento**, serve quando se é necessário salvar estados anteriores de um objeto, similar a funcionalidade de "ctrl+Z".

No caso do exemplo, poderíamos guardar diretamente a lista de Contratos. Mas veja que isso depende do problema. No nosso caso, não tínhamos outra informação para associar ao "estado". Se tivéssemos que armazenar, por exemplo, a data que o estado foi salvo, a classe Estado faria sentido. Mas caso contrário poderíamos simplismente armazenar a classe `Contrato` na lista diretamente.

Um possível problema deste padrão é a quantidade de memória que ele pode ocupar, afinal estamos guardando muitas instâncias de objetos que podem ser pesados.

Por isso, dependendo do tamanho dos seus objetos, a classe Estado pode passar a guardar não o objeto todo, mas sim somente as propriedades que mais fazem sentido.

Nada impede você também de limitar a quantidade máxima de objetos no histórico que será armazenado.

### Aula 11
Quando temos expressões que devem ser avaliadas, e a transformamos em uma estrutura de dados, e depois fazemos com que a própria árvore se avalie, damos o nome de **Interpreter**.

O padrão é bastante útil quando temos que implementar interpretadores para DSLs, ou coisas similares. É um padrão bem complicado, mas bastante interessante.

Essa idéia do Interpreter é utilizada dentro do C# dentro da API de expressões que são utilizadas para estender o LINQ.

O padrão Interpreter é geralmente útil para interpretar DSLs. É comum que, ao ler a string (como por exemplo 2+3/4), o programa transforme-a em uma estrutura de dados melhor (como as nossas classes Expressao) e aí interprete essa árvore.

É realmente um padrão de projeto bem peculiar, e com utilização bem específica.

### Aula 12
Quando temos uma árvore, e precisamos navegar nessa árvore de maneira organizada, podemos usar um **Visitor**, que foi o padrão de projeto implementado nessa aula.

A finalidade do visitor dentro do código é simplesmente percorrer toda a árvore de expressão para executar alguma lógica. Nesse capítulo, ele foi utilizado para imprimir as expressões, mas ele também poderia ser utilizado para realizar cálculos com a expressão ou qualquer outra tarefa que dependa do processamento dos nós de nossa árvore de expressão.

### Aula 13
Nessa solução estamos ligando duas hierarquias que possuem responsabilidades distintas através de composição de classes. Essa composição funciona como uma ponte entre as duas hierarquias de classes e, por isso, esse padrão é conhecido como **bridge**.

Quando temos uma hierarquia de classes que é responsável por diversas características do sistema (formatação e envio da mensagem, no exemplo), podemos utilizar o padrão bridge para separar as características em diversas hierarquias ligando-as através da composição de classes.

Na implementação do bridge que fizemos nesse capítulo, podemos ver que o bridge pode utilizar o strategy em sua implementação: a mensagem em seu método `Envia` utiliza o strategy para decidir qual é a estratégia de envio que será utilizada pela aplicação.

### Aula 14
O nome dessa padrão de projeto, que facilita a criação de comandos, chama-se **Command**. Usamos ele quando temos que separar os comandos que serão executados do objeto que ele pertence. Um bom exemplo disso é o uso de filas de trabalho.

Podemos ser criativos e usar outros padrões de projeto de acordo com o problema que temos em mãos. Podemos usar Memento para restaurar estados de objetos que foram alterados por um Command.

### Aula 15
Essa classe `GeradorDeXml` é uma classe que tem a responsabilidade de adaptar o código da API do C# para geração de XML para um código orientado a objetos que é entendido pela aplicação. Esse é um padrão de projeto chamado **Adapter**.

Utilizamos o adapter quando queremos adaptar o código de um sistema legado ou de uma biblioteca para que ele trabalhe corretamente com o sistema orientado a objetos que está sendo desenvolvido.

Veja que a implementação do Adapter é muito parecida com a implementação do Command e do Strategy, a diferença está realmente no propósito do padrão, o problema que está sendo resolvido.

### Aula 16
Esse padrão de projeto, que provê uma "fachada" para os serviços disponibilizados pelos sub-sistemas, é conhecido pelo nome de **Facade**. Como essa classe provê acesso a todos os outros sub-sistemas, é bem comum também que não haja mais de uma instância dessa classe espalhada pelo sistema.

Vamos resolver isso com uma única classe, que servirá de "fábrica", e sempre retornará a mesma instância... A implementação acima é o que chamamos de `Singleton`. Ele faz com que só exista uma única instância da classe em todo o sistema!

Mas, apesar dos dois padrões serem bastante populares, seu uso deve ser feito com cautela. O Singleton, por exemplo, quando mal utilizado, acaba por permitir ao usuário a utilização de variáveis globais (que é uma coisa que a programação procedural já mostrou que é problemático). 

Uma Facade tende a ser muito acoplada, e ter uma interface gorda. Facades menores podem até ser úteis, mas também devem ser usadas com parcimônia.

RESUMINDO: O Singleton nos ajuda a ter uma única instância do objeto ao longo do sistema. E uma façade serve como uma frente única para os serviços disponibilizados por um ou mais sub-sistemas, provendo uma maneira mais simples para consumo do mesmo.



