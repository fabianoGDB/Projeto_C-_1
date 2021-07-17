﻿using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X" ){
                switch(opcaoUsuario){
                    case "1":
                        //TODO: adicionar aluno
                        break;
                    case "2":
                        //TODO: listar alunos
                        break;
                    case "3":
                        //TODO: calcular media geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            
        }

        private static string ObterOpcaoUsuario(){
            Console.WriteLine("Infore a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
