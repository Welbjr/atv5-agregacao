using System;
using System.Collections.Generic;

namespace ProjFutebol_01
{
    class Time
    {
        //atributos
        private string nome;
        private Int32 vitorias;
        private Int32 derrotas;
        private Int32 empates;
        private List<Jogador> jogadores;

        //construtor
        public Time(string Nome)
        {
            this.nome = Nome;
            this.vitorias = 0;
            this.derrotas = 0;
            this.empates = 0;
            this.jogadores = new List<Jogador>();
        }

        //metodos
        public string Nome
        {
            get { return nome; }
        }

        public string getStatus()
        {
            return "O status do Time " + this.Nome +
                    " é Vitorias:" + this.Vitorias +
                    "\tDerrotas: " + this.derrotas +
                    "\tEmpates: " + this.empates;
        }

        public Int32 Vitorias
        {
            get { return vitorias; }
            set { vitorias += value; }
        }

        public Int32 Derrotas
        {
            get { return derrotas; }
            set { derrotas += value; }
        }

        public Int32 Empates
        {
            get { return empates; }
            set { empates += value; }
        }

        public void contratarJogador(Jogador J)
        {
            this.jogadores.Add(J);
        }

        private string demitirJogador(Jogador J)
        {
            int buscarJogador = this.jogadores.IndexOf(J);

            string strRetorno = "Jogador" + J.getNome();
            if (buscarJogador != -1)
            {
                this.jogadores.RemoveAt(buscarJogador);
                return strRetorno + " demitido.";
            }
            return "Não foi possível demitir " + strRetorno;
        }

        private Jogador getJogador(int camisa)
        {
            return jogadores.Find(j => j.getCamisa().Equals(camisa));
        }

        public void gol(int camisa)
        {
            this.getJogador(camisa).Gols = 1;
        }

        public void getDescricaoJogadores()
        {
            foreach (Jogador jog in jogadores)
            {
                Console.WriteLine(jog.getDescricao());
            }
        }
    }
    
}
