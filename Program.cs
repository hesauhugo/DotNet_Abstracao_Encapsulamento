using DotNet_Introducao_Abstracao_Encapsulamento.Models;

ContaCorrente conta = new ContaCorrente(123,1000);
conta.ExibirSaldo();
conta.Sacar(5000);
conta.ExibirSaldo();