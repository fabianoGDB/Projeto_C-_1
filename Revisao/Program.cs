using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            string opcaoUsuario = ObterOpcaoUsuario();
            var indiceAluno = 0;
            
            while(opcaoUsuario.ToUpper() != "X" ){
                switch(opcaoUsuario){
                    case "1":
                        //TODO: adicionar aluno
                        Aluno aluno = new Aluno();
                        
                        Console.WriteLine("Informe o nome do aluno");
                        Console.Write("Nome: ");
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno");
                        Console.Write("Nota: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.Nota = nota;
                        }else{
                            throw new ArgumentException("O valor da nota dever ser um decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        foreach(var a in alunos){

                            if(!string.IsNullOrEmpty(a.Nome)){
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                            }else{
                                Console.WriteLine("O programa tem uma lacuna para aluno.");
                            }
                        }
                        //TODO: listar alunos
                        break;
                    case "3":
                        //TODO: calcular media geral
                        decimal notaTotal = 0;
                        int numerosAln = 0;
                        for (int i = 0; i < alunos.Length; i++){
                            if (!string.IsNullOrEmpty(alunos[i].Nome)){
                                notaTotal = notaTotal + alunos[i].Nota;
                                numerosAln++;
                            }
                        }

                        var mediaGeral = notaTotal / numerosAln;
                        EConceito conceitoGeral;

                        if(mediaGeral < 2){
                            conceitoGeral = EConceito.E;
                        }else if(mediaGeral < 4){
                            conceitoGeral = EConceito.D;
                        }else if(mediaGeral < 6){
                            conceitoGeral = EConceito.C;
                        }else if(mediaGeral < 8){
                            conceitoGeral = EConceito.B;
                        }else{
                            conceitoGeral = EConceito.A;
                        }

                        Console.WriteLine("----------------------------");
                        Console.WriteLine($"Média Geral: {mediaGeral} - Conceito: {conceitoGeral}");
                        Console.WriteLine("----------------------------");
                        break;
                    default:
                        Console.WriteLine("Digite algo dentro das opções :^) ");
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            
        }

        private static string ObterOpcaoUsuario(){
            Console.WriteLine("-------------------------");
            Console.WriteLine("Infore a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine("-------------------------");

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
