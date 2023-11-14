using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    public class Pista
    {
        public Pista(int tamanho, Corredor atleta)
        {
            this.Tamanho = tamanho;
			this.Atleta = atleta;
			this.posAtleta = 0;
			this.corredorPista = "";
			this.pista = "";
        }

        private String pista = "";
        private String corredorPista = "";

        private int tamanho;

		public int Tamanho
		{
			get { return tamanho; }
			set { tamanho = value; }
		}

		private int posAtleta;

		public int PosAtleta
		{
			get { return this.posAtleta; }
			// set { this.posAtleta = value; }
		}

		private Corredor atleta;

		public Corredor Atleta
		{
			get { return atleta; }
			set { atleta = value; }
		}


		

		public Boolean AtualizarCorrida()
		{
            Boolean ganhou = false;
            if (this.posAtleta < this.Tamanho)
            {
                this.posAtleta += this.Atleta.Correr();
            }
            if (this.posAtleta >= this.Tamanho)
            {
                ganhou = true;
                this.posAtleta = this.Tamanho;                
            }
            return ganhou;

        }


		public void ExibirPista()
		{
            //Monta a imagem do corredor na pista

            pista = "";
            corredorPista = "";

            for (int i = 1; i <= this.Tamanho; i++)
            {
                pista += "_";
                if (i == this.PosAtleta)
                {
                    this.corredorPista += this.Atleta.Nome;
                }
                else
                {
                    this.corredorPista += " ";
                }

            }
            //exibir a minha pista e o corredor
            Console.WriteLine(corredorPista);
            Console.WriteLine(pista);
        }
    }
}
