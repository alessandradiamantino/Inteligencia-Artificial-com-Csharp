using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ia
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int cont = 0;
            individuo melhordetodos = new individuo(10, r);
           
            populacao p = new populacao(5, 10, r);
            p.Recombinacao(p.ind[0], p.ind[1]);
           
            /*
            //p.imprimirpop();
            p.buscamelhor();
            Console.WriteLine("____________________\n");
            Console.WriteLine("Melhor indivíduo:");
            p.melhorInd.imprimir();
            melhordetodos.copia(p.melhorInd);

            while (cont < 1000) // vai executar 10 gerações
            {

                p.Mutacao();
                p.buscamelhor();
             
                if(p.melhorInd.adapt < melhordetodos.adapt) melhordetodos.copia(p.melhorInd);

                Console.WriteLine("____________________\n");
                Console.WriteLine("Melhor indivíduo da geração : " + (cont+1));
                p.melhorInd.imprimir();
                Console.WriteLine("____________________\n");

                cont++;
            }
            Console.WriteLine("____________________\n");
            Console.WriteLine("Melhor de todas as gerações:");
            melhordetodos.imprimir();
            Console.WriteLine("____________________\n");


            individuo a = new individuo(10, r);
            individuo b = new individuo(10, r);

            a.converterDec();
            a.fitness();
            Console.WriteLine("Indivíduo original:\n ");
            a.imprimir();        

            //Console.WriteLine("\nIndivíduo backup: ");
            //b.imprimir();

            Console.WriteLine("\nMutação\n");

            while(cont < 100000)
            {
                b.copia(a);
                a.mutacao();

                if (a.adapt > b.adapt) a.copia(b);

                cont++;
            }

            Console.WriteLine("Solução: ");
            a.imprimir();
            */
            Console.ReadKey();
        }
    }
}
