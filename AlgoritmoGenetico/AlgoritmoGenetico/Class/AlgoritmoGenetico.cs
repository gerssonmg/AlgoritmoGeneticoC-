using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico.Class
{
    public class AlgoritmoGenetico
    {
        private double taxaCrossover;
        private double taxaMutacao;
        static int PAI = 0;
        static int MAE = 1;

        public AlgoritmoGenetico(double taxaCrossover, double taxaMutacao)
        {
            this.taxaCrossover = taxaCrossover;
            this.taxaMutacao = taxaMutacao;
        }
    
        public Populacao executaAG(Populacao pop)
        {
            //Inicio do AG
            //Avaliação da Populacao
            Populacao novaPopulacao = new Populacao();
            List<Individuo> popBuffer = new List<Individuo>();


            for(int i = 0; i < (Constants.sizePopulacao/2); i++)
            {
                //Selecionar os pais para cruzamento
                Individuo pai = Roleta(pop);
                Individuo mae = Roleta(pop);

                //Realizar o Cruzamento
                Individuo[] filhos = Crossover(pai, mae);

                //Aplicar a mutação
                Individuo filhoA = Mutacao(filhos[0]);
                Individuo filhoB = Mutacao(filhos[1]);

                popBuffer.Add(filhoA);
                popBuffer.Add(filhoB);

            }
            //Apagar os velhos membros
            //Inserir novos Membros
            for(int i = 0; i < Constants.sizePopulacao; i++)
            {
                novaPopulacao.setIndividuo(i, popBuffer[i]);
            }
            popBuffer = null;

            //Re-Avaliar a pop
            novaPopulacao.atuazarValores();

            return novaPopulacao;
        }

        public Individuo[] Crossover(Individuo pai, Individuo mae)
        {
            Individuo[] novoInd = new Individuo[2];
            int pontoDeCorte = Constants.random.Next(0, Constants.sizeCromossomo - 1);

            Individuo paiBuffer = new Individuo();
            Individuo maeBuffer = new Individuo();

            novoInd[PAI] = new Individuo();
            novoInd[MAE] = new Individuo();

            for(int i = 0; i< Constants.sizeCromossomo; i++)
            {
                paiBuffer.setGene(i, pai.getGene(i));
                maeBuffer.setGene(i, mae.getGene(i));

                novoInd[PAI].setGene(i, pai.getGene(i));
                novoInd[MAE].setGene(i, mae.getGene(i));
            }

            if(Constants.random.NextDouble() < taxaCrossover)
            {
                //Console.Write("Caiu na taxa de crossover!   Ponto de Corte: " + pontoDeCorte + "\n");
                for(int i = pontoDeCorte; i < Constants.sizeCromossomo; i++)
                {
                    novoInd[PAI].setGene(i, maeBuffer.getGene(i));
                    novoInd[MAE].setGene(i, paiBuffer.getGene(i));
                }
            }


            return novoInd;
        }

        public Individuo Mutacao(Individuo ind)
        {
            if(Constants.random.NextDouble() <= taxaMutacao)
            {
                int genePosition = Constants.random.Next(0, Constants.sizeCromossomo);
                ind.mutarBit(genePosition);
                return ind;
            }

            return ind;
        }

        public Individuo Roleta(Populacao pop)
        {
            double numSorteado = (Constants.random.NextDouble() * 100);

            foreach(Individuo ind in pop.getPopulacao())
            {
                if(numSorteado >= ind.getRangeRoleta()[0] && numSorteado <= ind.getRangeRoleta()[1])
                {
                    return ind;
                }
            }
            //Nunca vai acontecer
            return null;
        }

    }
}
