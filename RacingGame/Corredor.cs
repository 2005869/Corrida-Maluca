using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame
{
    public class Corredor
    {
        public static Random rnd = new Random();
        public Corredor()
        {
            this.Nome = "";
        }

        public Corredor(String nome)
        {
            this.Nome = nome;
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set
            {
                if (value.Length > 0) { this.nome = value[0].ToString().ToUpper(); }

                if (value.Length == 0)
                {
                    this.nome = "X";
  
                }
            }
        }

        public int Correr()
        {            
            return Corredor.rnd.Next(1, 10);
        }
	}
}
