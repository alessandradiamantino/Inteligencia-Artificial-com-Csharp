using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ia
{
    class individuo
    {
        public int[] b;
        public int n;
        public Random r;
        public double fenotipo;
        public double x;
        public double adapt;
        private int i;
        public individuo()
        {

        }
        public individuo(int n, Random r)
        {
            this.n = n;
            b = new int[n];
            this.r = r;

            for (i = 0; i < n; i++)
            {
                b[i] = r.Next(0, 2);
            }
        }

        public void imprimir()
        {
            for (i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Fenótipo: " + fenotipo);
            Console.WriteLine("X: " + x);
            Console.WriteLine("Adaptabilidade: " + adapt);
        }

        public void converterDec()
        {
            double soma = 0;
            double aux;
            for (i = 0; i < n; i++)
            {
                aux = n - 1 - i;
                soma = soma + b[i] * Math.Pow(2.0, aux);
            }
            fenotipo = soma;
            x = 6 * (fenotipo / (Math.Pow(2.0, n) - 1));
        }

        public void fitness()
        {
            adapt = x * x - 7 * x + 10;
        }

        public void mutacao()
        {
            int aux = r.Next(n);
           // Console.WriteLine("Número escolhido para a mutação: " + aux);

            if (b[aux] == 0)
            {
                b[aux] = 1;
                fenotipo = fenotipo + Math.Pow(2, aux);
            }
            else
            {
                b[aux] = 0;
                fenotipo = fenotipo - Math.Pow(2, aux);
            }

            x = 6 * (fenotipo / (Math.Pow(2.0, n) - 1));
            fitness();
        }

        public void copia(individuo indi)
        {
            for(i = 0; i < n; i++)
            {
                this.b[i] = indi.b[i]; 
            }
            this.n = indi.n;
            this.r = indi.r;
            this.fenotipo = indi.fenotipo;
            this.adapt = indi.adapt;
            this.x = indi.x;
        }
    }
}