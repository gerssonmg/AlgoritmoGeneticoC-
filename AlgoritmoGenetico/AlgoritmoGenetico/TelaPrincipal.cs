using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgoritmoGenetico.Class;
using ZedGraph;

namespace AlgoritmoGenetico
{
    public partial class TelaPrincipal : Form
    {
        private Populacao pop;

        private GraphPane panePop;
        private GraphPane paneMedia;

        private PointPairList curvaGrafico = new PointPairList();
        private PointPairList populacaoGrafico = new PointPairList();
        private PointPairList mediaPopulacao = new PointPairList();

        private int cont = 0;

        public TelaPrincipal()
        {
            InitializeComponent();

            btnIniciarAG.Enabled = false;

            panePop = zedPopulacao.GraphPane;
            panePop.Title.Text = "Evolução";
            panePop.XAxis.Title.Text = "Gerações";
            panePop.YAxis.Title.Text = "Individuos";
            zedPopulacao.Refresh();

            paneMedia = zedMediaPopulacao.GraphPane;
            paneMedia.Title.Text = "Média da população";
            paneMedia.XAxis.Title.Text = "Gerações";
            paneMedia.YAxis.Title.Text = "Média Fitness";
            zedMediaPopulacao.Refresh();

            for(int i = 0; i < Constants.functionXSize; i++)
            {
                curvaGrafico.Add(i, Constants.function1(i));
            }

            LineItem func = panePop.AddCurve("Função", curvaGrafico, Color.Red, SymbolType.None);

            zedPopulacao.AxisChange();
            zedPopulacao.Invalidate();
            zedPopulacao.Refresh();

            zedMediaPopulacao.AxisChange();
            zedMediaPopulacao.Invalidate();
            zedMediaPopulacao.Refresh();


        }


        private void btnCriarPop_Click(object sender, EventArgs e)
        {
            btnIniciarAG.Enabled = true;
            pop = new Populacao();
            populacaoGrafico = new PointPairList();

            for(int j = 0; j < Constants.sizePopulacao; j++)
            {
                populacaoGrafico.Add(pop.getPopulacao()[j].getInt(), pop.getPopulacao()[j].getFitness());
            }

            LineItem inds = panePop.AddStick("Indivuos", populacaoGrafico, Color.Blue);
            zedPopulacao.AxisChange();
            zedPopulacao.Invalidate();
            zedPopulacao.Refresh();
        }

        private void btnIniciarAG_Click(object sender, EventArgs e)
        {
            double taxaMutacao = double.Parse(txtTaxaMutacao.Text);
            double taxaCrossover = double.Parse(txtTaxaCrossover.Text);
            int iteracoes = int.Parse(txtIteracoes.Text);
            Console.Write(taxaMutacao.ToString() + "\n");
            Console.Write(taxaCrossover.ToString() + "\n");
            Console.Write(iteracoes.ToString() + "\n");

            Class.AlgoritmoGenetico ag = new Class.AlgoritmoGenetico(taxaCrossover, taxaMutacao);

            for (int i = 0; i < iteracoes; i++)
            {
                pop = ag.executaAG(pop);

                mediaPopulacao.Add(i, pop.getMediaPopulacao());

                zedPopulacao.GraphPane.CurveList.Clear();
                zedPopulacao.GraphPane.GraphObjList.Clear();

                zedMediaPopulacao.GraphPane.CurveList.Clear();
                zedMediaPopulacao.GraphPane.GraphObjList.Clear();

             
                populacaoGrafico = new PointPairList();

                for(int j = 0; j < Constants.sizePopulacao; j++)
                {
                    populacaoGrafico.Add(pop.getPopulacao()[j].getInt(), pop.getPopulacao()[j].getFitness());
                }

                LineItem media = paneMedia.AddCurve("Média", mediaPopulacao, Color.Green, SymbolType.None);             
                LineItem func = panePop.AddCurve("Função", curvaGrafico, Color.Red, SymbolType.None);
                LineItem indv = panePop.AddStick("Indivíduo", populacaoGrafico, Color.Blue);

                zedPopulacao.AxisChange();
                zedPopulacao.Invalidate();
                zedPopulacao.Refresh();

                zedMediaPopulacao.AxisChange();
                zedMediaPopulacao.Invalidate();
                zedMediaPopulacao.Refresh();
            }

            pop.OrdenarPopulacao();

            string pioresInds = string.Empty;
            for(int i = 0; i < 10; i++)
            {
                pioresInds += pop.getPopulacao()[i].PrintIndividuo() + "\n";
            }

            string melhoresInds = string.Empty;
            for (int i = Constants.sizePopulacao - 1; i > (Constants.sizePopulacao - 1) - 10; i--)
            {
                melhoresInds += pop.getPopulacao()[i].PrintIndividuo() + "\n";
            }

            txtMelhoresInd.Text = melhoresInds;
            txtPioresInd.Text = pioresInds;


        }














        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        
    }
}
