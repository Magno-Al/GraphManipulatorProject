# Trabalho de Algoritmos em Grafos
<<<<<<< HEAD

Trabalho desenvolvido para a disciplina de Algoritmos em Grafos, ministrada pelo professor Walison, no curso de Engenharia da Computa��o da Pontif�cia Universidade Cat�lica de Minas Gerais (PUC Minas).

## Alunos:
 - Alberto Magno
 - Bruno Guimar�es Bitencourt
 - Oscar Dias 


### �ndice

1. [Objetivos](#objetivos)
	1. [Descri��o](#descricao)
	1. [Pr�-requisitos](#pre-requisitos)
1. [Instala��o e Execu��o](#instalacao-e-execucao)
1. [Utiliza��o B�sica](#utilizacao-basica)
1. [Implementa��o](#implementacao)
	1. [Classe Vertex.cs](#classe-vertex)
	1. [Classe Edge.cs](#classe-edge)
	1. [Classe Graph.cs](#classe-graph) 
1. [Exemplo de Utiliza��o](#exemplo-de-utilizacao)
	1. [Grafo N�o Direcionado](#exemplo-grafo-direcionado) 
	1. [Grafo Direcionado](#exemplo-grafo-direcionado)
1. [Conclus�o](#conclusao)



# Objetivos
<a name="#objetivos"></a>

## Descri��o
<a name="#descricao"></a>
O trabalho consiste na implementa��o de uma aplica��o que realiza manipula��es em grafos utilizando a linguagem C#.

## Pr�-requisitos
<a name="#pre-requisitos"></a>
- Representa��o do grafo utilizando matriz de adjac�ncia.
- Representa��o do grafo utilizando lista de adjac�ncia.
- Cria��o de um grafo com um n�mero vari�vel de v�rtices (o n�mero de v�rtices deve ser inserido pelo usu�rio).
- Possibilidade de definir se o grafo � direcionado ou n�o.
- Implementa��o das opera��es de cria��o e remo��o de arestas.
- Identifica��o da vizinhan�a de um v�rtice (grafo n�o direcionado) ou sucessores e predecessores (grafo direcionado)
- Identifica��o do grau de um v�rtice
- Verifica��o das propriedades de ser um grafo simples, regular, completo e bipartido.

# Instala��o e Execu��o
<a name="#instalacao-e-execucao"></a>
Para executar o programa � necess�rio clonar o reposit�rio atrav�s do comando:
```bash
git clone https://github.com/Magno-Al/GraphManipulatorProject.git
```

Ap�s clonar o reposit�rio, abra a pasta `bin` do projeto conforme mostrado na figura abaixo:

<p align="center">
  <img src="./imagens/passo1.png" alt="Diret�rios ap�s clonagem do reposit�rio">
</p>

Em seguida, entre no diret�rio 'Release/net6.0-windows' e execute o arquivo 'GraphManipulator.exe' conforme mostrado abaixo:

<p align="center">
  <img src="./imagens/passo2.png" alt="Execu��o do GraphManipulator">
</p>

Dessa forma o programa ser� executado.
 <p align="center">
  <img src="./imagens/passo3.png" alt="Execu��o do GraphManipulator" width="80%">
</p>

# Utiliza��o B�sica
<a name="#utilizacao-basica"></a>

O primeiro passo para utiliza��o do sistema � selecionar a op��o se deseja criar um grafo direcionado ou n�o (quadro em vermelho). E apartir disso clicar no bot�o "Start" (quadro em amarelo).
 <p align="center">
  <img src="./imagens/util-01.png" alt="Execu��o do GraphManipulator" width="80%">
</p>

A partir disso, o sistema ir� habilitar a op��o de inserir o n�mero de v�rtices, conforme mostrado abaixo:
 <p align="center">
  <img src="./imagens/util-02.png" alt="Execu��o do GraphManipulator" width="80%">

Ap�s gerar o grafo, sistema habilitar� as op��es de Adicionar ou Remover Areastas, al�m de habilitar os combos na �rea de Gerenciar Arestas. Al�m disso, � poss�vel a visualiza��o do grafo clicando no bot�o **Lista de Adjac�ncia** ou **Matriz de Adjac�ncia**
 <p align="center">
  <img src="./imagens/util-03.png" alt="Execu��o do GraphManipulator" width="80%">

Na parte inferior da tela, � poss�vel a partir de um seletor verifar as informa��es de grau do v�rtice e vizinhan�a do v�rtice. No caso de um grafo direcionado, os par�metros grau do v�rtice de entrada, grau do v�rice de sa�da, predecessores e sucessores ir�o aparecer. Al�m disso, informa��es se o grafo � simples, regular completo e bipartido.
<p align="center">
  <img src="./imagens/util-04.png" alt="Execu��o do GraphManipulator" width="80%">


# Implementa��o
<a name="#implementacao"></a>
A principal classe do projeto � a classe 'Graph.cs', que � respons�vel por manipular o grafo. Ela � baseada na implementa��o de outras duas classes: 'Vertex' e 'Edges'.

## Classe `Vertex`
<a name="#classe-vertex"></a>
A classe Vetex � respons�vel por representar um v�rtice do grafo. Ela possui os seguintes atributos:
```csharp
// Atributos da Classe Vertex
public string Name { get; set; } // Nome do v�rtice
public bool? ColorMark { get; set; } // Marca��o de cor
```


## Classe 'Edge'
<a name="#classe-edge"></a>
A classe Edge � respons�vel por representar uma aresta do grafo. Ela possui os seguintes atributos:
```csharp
// Atributos da Classe Edge
public string Name { get; set; } // Nome da aresta
public Vertex Predecessor { get; set; } // V�rtice de origem
public Vertex Successor { get; set; } // V�rtice de destino
```


### Classe `Graph`
<a name="#classe-graph"></a>
A classe Graph � respons�vel por manipular o grafo. Ela possui os seguintes atributos:
```csharp
public bool IsDirectGraph { get; set; }// Indica se o grafo � direcionado ou n�o
private List<Vertex> Vertices { get; set; }// Lista de v�rtices do grafo
private List<Edge> Edges { get; set; }// Lista de arestas do grafo
public Dictionary<string, List<string>> AdjacencyList { get; private set; } // Lista de adjac�ncia que mapeia cada v�rtice para seus v�rtices adjacentes
public int[,] AdjacencyMatrix { get; private set; }// Matriz de adjac�ncia que representa as conex�es entre os v�rtices
```

## Subt�tulo 1


## Subt�tulo 2

### Subsubt�tulo



=======
>>>>>>> 9f8b80108325a31725bfcb4fca027437271556de
