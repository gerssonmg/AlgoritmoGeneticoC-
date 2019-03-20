using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AlgoritmoGenetico.Class
{
    public class Individuo
    {
        private BitArray cromossomo;                                    //Vetor de bits, possui apenas dois estatos, true ou false  
        private double fitness;                                         //Nota de aptidao do individuo
        private double fitnessPercent;                                  //A porcentagem do individuo, o quão esle é para reproduzir (%)
        private double[] faixaRoleta = { 0, 0 };                        //Faixa da pizza em que é provavel que ele seja seleciono
      
        //Construtor da classe
        public Individuo()
        {
            //Instancia o cromossomo com a quantidade de bits informados na classe Constants
            this.cromossomo = new BitArray(Constants.sizeCromossomo);

            int i;
            for(i = 0; i < cromossomo.Length; i++)
            {
                this.cromossomo[i] = (Constants.random.NextDouble() >= 0.5f) ? true : false;  //Popula o vetor com bits aleatorios
            }
        }

        public void mutarBit(int position)
        {
            if (position < cromossomo.Length)
            {
                cromossomo.Set(position, cromossomo[position] == false ? true : false);
            }
        }

        public BitArray getCromossomo()
        {
            return this.cromossomo;
        }

        public string PrintIndividuo()
        {
            string result = string.Empty;
            result += "Bits:   ";
            for (int i = cromossomo.Length - 1; i >= 0; i--)
            {
                result = result + (cromossomo[i] == false ? "0" : "1");
            }

            result += "    INT:   " + getInt() + "  Aptidão:  " + getFitness() + "   Porcentagem:  " + getFitnessPercent();

            return result;
        }

        public void setRangeRoleta(double inicio, double fim)
        {
            faixaRoleta[0] = inicio;
            faixaRoleta[1] = fim;
        }

        //Inserir valor booleano em um determinado local do vetor do cromossomo
        public void setGene(int position, bool gene)
        {
            this.cromossomo[position] = gene;
        }

        public bool getGene(int position)
        {
            return this.cromossomo[position];
        }

        public void setFitness(double fitness)
        {
            this.fitness = fitness;
        }

        public double getFitness()
        {
            return this.fitness;
        }

        public void setFitnessPercent(double fitnessPercent)
        {
            this.fitnessPercent = fitnessPercent;
        }

        public double getFitnessPercent()
        {
            return this.fitnessPercent;
        }

      
        public double[] getRangeRoleta()
        {
            return this.faixaRoleta;
        }

        public int getInt()
        {
            if (this.cromossomo.Length > 32)
                throw new ArgumentException("O comprimento do cromossomo deve ser no máximo 32 bits.");

            int[] array = new int[1];
            this.cromossomo.CopyTo(array, 0);
            return array[0];
        }


    }
}
