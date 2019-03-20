using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico.Class
{
    public class Populacao
    {
        private Individuo[] populacao;                              //Grupo de Individuos, vetor com N individuos

        //Construtor da classe populacao
        public Populacao()
        {
            this.populacao = new Individuo[Constants.sizePopulacao];
            int i;
            for(i = 0; i < Constants.sizePopulacao; i++)
            {
                populacao[i] = new Individuo();
            }
            //Alaviação da populacao 
            calcularFitness();
            calcularFitnessPercent();
            calcularRangeRoleta();
        }

        public void calcularFitness()
        {
            int i;
            for(i = 0; i < Constants.sizePopulacao; i++)
            {
                //Para calcular, aplique o valor inteiro do individuo na função de aptidao
                this.populacao[i].setFitness(Constants.function1(this.populacao[i].getInt()));
            }
        }

        public void calcularFitnessPercent()
        {
            double somatoriaFitness = 0;

            //Somatoria de todos os valores de aptidao
            for(int i = 0; i < Constants.sizePopulacao; i++)
            {
                somatoriaFitness += populacao[i].getFitness();
            }

            for(int i = 0; i < Constants.sizePopulacao; i++)
            {
                populacao[i].setFitnessPercent((populacao[i].getFitness() * 100) / somatoriaFitness);
            }
        }

        //Calcular o Range da roleta em que o individuos faz parte
        public void calcularRangeRoleta()
        {
            //Primeiramente deve-se ordenar a populacao em ordem crescente 
            //Chamar o metodo para ordenar a populacao
            OrdenarPopulacao();
            double somatoria = 0;

            for(int i = 0; i < Constants.sizePopulacao; i++)
            {
                if(i == 0)
                {
                    somatoria += populacao[i].getFitnessPercent();
                    populacao[i].setRangeRoleta(0, somatoria);
                }
                else if(i == (Constants.sizePopulacao - 1))
                {
                    populacao[i].setRangeRoleta(somatoria, 100f);
                }
                else
                {
                    populacao[i].setRangeRoleta(somatoria, somatoria + populacao[i].getFitnessPercent());
                    somatoria += populacao[i].getFitnessPercent();
                }
            }
        }

        public void atuazarValores()
        {
            //CalcularFitness
            calcularFitness();

            //CalcularFitnessPercent;
            calcularFitnessPercent();

            //CalcularRangeRoleta
            calcularRangeRoleta();
        }
        
        public Individuo[] getPopulacao()
        {
            return this.populacao;
        }

        public void setIndividuo(int posicao, Individuo individuo)
        {
            this.populacao[posicao] = individuo;
        }

        public double getMediaPopulacao()
        {
            double sum = 0;
            foreach(Individuo ind in populacao)
            {
                sum += ind.getFitness();
            }

            return sum / Constants.sizePopulacao;
        }


        //Metodo para ordenar a populacao
        public void OrdenarPopulacao()
        {
            Individuo aux = new Individuo();

            for (int i = 0; i < Constants.sizePopulacao; i++)
            {
                for (int j = 0; j < Constants.sizePopulacao; j++)
                {
                    if (populacao[i].getFitnessPercent() < populacao[j].getFitnessPercent())
                    {
                        aux = populacao[i];
                        populacao[i] = populacao[j];
                        populacao[j] = aux;
                    }
                }
            }
        }

        public string printPop()
        {
            string result = string.Empty;

            for(int i = 0; i< Constants.sizePopulacao; i++)
            {
                result = result + populacao[i].PrintIndividuo() + "    |    "
                                + populacao[i].getInt().ToString() + "    |    "
                                + populacao[i].getFitness().ToString() + "    |    "
                                + populacao[i].getFitnessPercent().ToString() + "    |    "
                                + populacao[i].getRangeRoleta()[0].ToString() + ":" + populacao[i].getRangeRoleta()[1].ToString() + "\n";
            }


            return result;
        }



    }

    
}
