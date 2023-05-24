# Paradigma
* Modelo de técnicas, estruturas e formas de solucionar um problema

# POO 
* Abstração, encapsulamento, herança e polimorfismo

## Abstração
* Uma classe é uma abstração
* Um objeto é a concretização daquela abstração

```csharp
    Pessoa pessoa = new Pessoa();
    pessoa.Nome = "Enzo";
    pessoa.Idade = 9 ; 
    pessoa.Apresentar();
```

## Encapsulamento
* Expor apenas os atributos e comportamentos necessários
* Algumas regras não são expostas
* Alguns bloqueios para que tal operação não seja feita fora da classe.
* Encapsulamento da variável saldo

```csharp 
    ContaCorrente conta = new ContaCorrente(123,1000);
    conta.ExibirSaldo();
    conta.Sacar(5000);
    conta.ExibirSaldo();
```
