using System;
using System.Collections.Generic;

namespace ExercicioConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Um instrutor possui três cursos: A, B e C, e deseja saber seu 
             número total de alunos. Seu programa deve ler os alunos dos 
             cursos A, B e C do instrutor Joaquim, depois mostrar a 
             quantidade total e alunos dele,  */
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();
            int n1;
            Console.WriteLine("Bem vindo profesor!");
            Console.Write("Quantos alunos possui matriculado no curso A: ");
            n1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n1; i++)
            {
                Console.Write("Informe o {0}º Id: ",(i+1));
                A.Add(int.Parse(Console.ReadLine()));
            }
            
            Console.Write("Quantos alunos possui matriculado no curso B: ");
            n1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n1; i++)
            {
                Console.Write("Informe o {0}º Id: ",(i+1));
                B.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Quantos alunos possui matriculado no curso C: ");
            n1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n1; i++)
            {
                Console.Write("Informe o {0}º Id: ", (i + 1));
                C.Add(int.Parse(Console.ReadLine()));
            }

            B.UnionWith(C);
            A.UnionWith(B);
            int count = 0;
            Console.WriteLine("-------------------------------");
            foreach (int x in A)
            {
                count++;
                Console.WriteLine("O {0}º aluno é o:{1}",count,x);
            }
            
            Console.WriteLine("Professor o sr. possui um total de {0} alunos ",count);
            Console.ReadLine();

        }
    }
}
