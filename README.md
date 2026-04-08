## CP1 - C#: Jogo de Cartas

### Requisitos:
- Modelar e criar estruturas adequadas para armazenar dados dos jogadores, partidas e histórico de rodadas
- Desenvolvimento de classes genéricas, modelando características comuns a jogos de cartas.

### Solução:
Este código implementa uma base para jogos de cartas, organizando em modelos principais em:
Carta, Jogador, Mão, Jogada, Rodada e Estatísticas.
A lógica específica do jogo permite adaptar para diferentes jogos (truco, poker, etc.).

### Carta:
- Representando os atributos genéricos de toda carta: Valor (Às, 2, Rei, Bloqueio...) e Tipo (Copas, Espadas, Vermelho, Verde...).
- Contém o método de virar a carta na mesa com VirarCarta().

### Jogador: 
- Contém Nome, Estatísitica e Mão.
- Contém a função de gerar mão aleatória e realizar uma jogada, subtraindo a carta na mão jogada.

### Mao:
- Armazena uma lista de cartas, mostra as cartas em posse e remove cartas jogadas

### Jogada: 
- Classe Record que associa o jogador a carta jogada

### Rodada
- Define o vencedor que não está desenvolvida, pois não há um jogo especifíco
- Número da rodada
- Registra a jogada e adiciona na lista jogadas

### Estatísticas
- Conta vitórias, derrotas e empates
- Métodos para registrar cada resultado
- ToString() retorna resumo formatad

## Integrantes:

Caio Alexandre dos Santos - RM: 558460

Leandro do Nascimento Souza - RM: 558893

Rafael de Mônaco Maniezo - RM: 556079

Vinicius Rozas Panucci de Paula Cont - RM: 555338
