﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
           
                contaDaGabriela.titular = "Gabriela";
                contaDaGabriela.agencia = 863;
                contaDaGabriela.numero = 863452;

                ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
                contaDaGabrielaCosta.titular = "Gabriela";
                contaDaGabrielaCosta.agencia = 863;
                contaDaGabrielaCosta.numero = 863452;

            Console.WriteLine("Igualdade de referência " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idadeModificada = 27;

            Console.WriteLine("Igauldade tipos valores " + (idade == idadeModificada));


            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine(contaDaGabrielaCosta == contaDaGabriela);

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);

            if(contaDaGabriela.saldo >= 100)
            {
                contaDaGabriela.saldo -= 100;
            }
        }
    }
}

