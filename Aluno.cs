using System;
using System.Collections.Generic;
using System.Text;

namespace faculdade
{
    class Aluno
    {
        //atributos da classe
        public String nome;
        public String rm;
        public Boolean ehBolsista;
        public double mensalidadefinal;

        //método para checar se é bolsista
        public void calculaMensalidade()
        {
            if (this.ehBolsista == true)
            {
                this.mensalidadefinal = 200.00;//é bolsista 50% de desconto
            }
            else
            {
                this.mensalidadefinal = 400.00;//não é bolsista então valor cheio
            }
        }
    }
}
