using System;

namespace ProjFutebol_01
{
    class Partida
    {
        //Atributos
        private DateTime data;
        private Time timeCasa;
        private Time timeVisitante;
        private int placarCasa;
        private int placarVisitante;

        //Construtor
        public Partida(DateTime dataPartida, Time Tcasa, Time Tvisitante)
        {
            this.data = dataPartida;
            this.timeCasa = Tcasa;
            this.timeVisitante = Tvisitante;
            this.placarCasa = 0;
            this.placarVisitante = 0;
        }

        //Metodos
        public int golCasa()
        {
            return placarCasa++;
        }

        public int golVisitante()
        {
            return placarVisitante++;
        }

        public string getPalacar()
        {
            if (this.placarCasa > this.placarVisitante)
            {
                this.timeCasa.Vitorias = 1;
                this.timeVisitante.Derrotas = 1;
                return "O vencedor da partida em " + this.data.ToString("dd-MM-yyyy") +
                    " entre " + this.timeCasa.Nome +
                    " x " + this.timeVisitante.Nome +
                    " foi o time " + this.timeCasa.Nome +
                    " com o placar de " + this.placarCasa.ToString() +
                    " a " + this.placarVisitante.ToString() + ".";
            }

            if (this.placarCasa == this.placarVisitante)
            {
                this.timeCasa.Empates = 1;
                this.timeVisitante.Empates = 1;
                return "Sem vencedor na partida em " + this.data.ToString("dd-MM-yyyy") +
                    " com o placar de " + this.placarCasa + " a " + this.placarVisitante;
            }

            this.timeVisitante.Vitorias = 1;
            this.timeCasa.Derrotas = 1;
            return "O vencedor da partida em " + this.data.ToString("dd-MM-yyyy") +
                " entre " + this.timeVisitante.Nome + " x " + this.timeCasa.Nome +
                " foi o time " + this.timeVisitante.Nome +
                " com o placar de " + this.placarVisitante + " a " + this.placarCasa;
        }

        public void jogar()
        {
            for(int i=0 ; i<9; i++ )
                {
                    golCasa();
                }
            golVisitante();
            
        }
    }
}