using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    public class Calculadora
    {
        public decimal Somar(decimal a, decimal b) => a + b;

        public decimal Subtrair(decimal a, decimal b) => a - b;

        public decimal Multiplicar(decimal a, decimal b) => a * b;

        public decimal Dividir(decimal a, decimal b)
        {
            if (b == 0)
                throw new DivideByZeroException("Não é possível dividir por zero.");
            return a / b;
        }

        public decimal Porcentagem(decimal valor, decimal porcentagem) => (valor * porcentagem) / 100;

        public decimal RaizQuadrada(decimal valor)
        {
            if (valor < 0)
                throw new ArgumentOutOfRangeException(nameof(valor), "Não é possível calcular a raiz quadrada de um número negativo.");
            return (decimal)Math.Sqrt((double)valor);
        }

        public decimal AoQuadrado(decimal valor) => valor * valor;

        public decimal Inverso(decimal valor)
        {
            if (valor == 0)
                return 0;

            return 1 / valor;
        }

        // utilizar no lugar do "RealizarOperacao()" do main.cs...
        public decimal ProcessarOperacao(decimal a, decimal b, string operacao)
        {
            return operacao switch
            {
                "+" => Somar(a, b),
                "-" => Subtrair(a, b),
                "*" => Multiplicar(a, b),
                "/" => Dividir(a, b),
                "%" => Porcentagem(a, b), 
                _   => throw new InvalidOperationException("Operação inválida.")
            };
        }
    }
}
