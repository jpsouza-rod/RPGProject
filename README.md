
#  RPG Project

O projeto de código de RPG é baseado no jogo eletrônico do gênero RPG Final Fantasy. O projeto visa implementar conceitos aprendidos no Bootcamp GFT Start #5 .NET da Digital Innovation One. 

### Conceitos Aplicados
 - Abstração
 - Herança
 - Polimorfismo
 - Encapsulamento

## RPG

<div align = center>
<img src = https://rpgamer.com/wp-content/uploads/2019/07/ff1psp200.jpg>
</div>
 
### Descrição
As classes Knight, Ninja e Wizard herdam da classe abstrata Hero. A classe Hero possui os atributos Name, Level, HP e DamageAttack. Os valores de HP (_Hit points_) e é atribuido por meio de um método abstrato.

Os atributos de HP e DamageAttack de cada herói é implementado de acordo com a classe do herói. As classes Knight e Ninja possuem maiores níveis de _Hit points_.   
 
 ### Dano de Ataque
Cada classe de herói possui um dano conforme a subclasse. 

  - 10 pontos + Bônus de Ataque | Ninja
  - 12 pontos + Bônus de Mágia  | Wizard  
  - 08 pontos + Bônus de Ataque | Knight

### Dano de Ataque com Bônus
Cada classe de herói possui uma sobrecarga no metódo de _attack_ com parâmetros inseridos pelo usuário. 

  - Ataque com Shuriken | Ninja
  - Ataque com Feitiço | Wizard  
  - Ataque Físico com Bônus   | Knight

## Instalação
Execute o código com os seguintes comandos
1. Clone o repositório do GitHub com o comando `git clone https://github.com/jpsouza-rod/Digital-Inovation-One.git `
2. Entre na pasta do projeto com `cd RPGProject`
3. Execute o programa com `dotnet run`

## Stack utilizada

**Back-end:**  .Net, C#

## Autores

- [@jpsouza-rod](https://www.github.com/jpsouza-rod)

