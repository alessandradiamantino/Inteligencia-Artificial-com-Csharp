using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ia
{
    class populacao
    {
        public individuo[] ind;
        public int tam;
        Random r;
        private int i;
        public individuo melhorInd;

        public populacao() { }

        public populacao(int n, int bits, Random r)
        {
            tam = n;
            this.r = r;
            ind = new individuo[tam];

            for(i = 0; i < tam; i++)
            {
                ind[i] = new individuo(bits, r);
                ind[i].converterDec();
                ind[i].fitness();
            }
            melhorInd = new individuo(bits, r);
        }

        public void imprimirpop()
        {
            for(i = 0; i < tam; i++)
            {
                Console.WriteLine("\n----------------\nIndivíduo: " + (i + 1));
                ind[i].imprimir();
            }
        }

        public void buscamelhor()
        {
            melhorInd.copia(ind[0]);
            for(i = 1; i <tam; i++)
            {
                if(ind[i].adapt < melhorInd.adapt)
                {
                    melhorInd.copia(ind[i]);
                }
            }
        }

        public void Mutacao()
        {
            for(i = 0; i < tam; i++)
            {
                ind[i].mutacao();
            }
        }
        //arrumar
        public void Recombinacao(individuo x, individuo y)
        {
            individuo f1 = new individuo(bits, r);
            individuo f2 = new individuo(bits, r);

            int corte = r.Next(bits);
            Console.WriteLine("Corte:" + corte,"-------------------\nPrimeiro\n");
            x.imprimir();
            Console.WriteLine("-------------------\nSegundo\n");
            y.imprimir();

            for (i = 0; i < corte; i++)
            {
                f1.b[i] = x.b[i];
                f2.b[i] = y.b[i];
            }
            for(i = corte; i < bits; i++)
            {
                f1.b[i] = x.b[i];
                f2.b[i] = y.b[i];
            }

            f1.converterDec();
            f2.converterDec();

            f1.fitness();
            f2.fitness();

            Console.WriteLine("-------------------\nFilho 1\n");
            f1.imprimir();
            Console.WriteLine("-------------------\nFilho 2\n");
            f2.imprimir();
        }

    }
}
