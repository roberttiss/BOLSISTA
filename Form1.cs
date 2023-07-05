using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faculdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //instancia da classe
        Aluno reg = new Aluno();//dizendo para a memória Ram que faremos uso da classe Aluno
        private void calculaMensalidade_Click(object sender, EventArgs e)
        {
            //entrada de dados para os atributos
            reg.nome = txtNOME.Text;
            reg.rm = txtRM.Text;



            if (checkBox1.Checked == true)//é bolsista ou seja o checkbox está clicado
            {
                reg.ehBolsista = true;//manda true para atributo ehBolsista



                reg.calculaMensalidade();//chama o método da classe



                //mostraRegistro ou seja mostra todos os dados da classe
                MessageBox.Show("Nome do aluno: " + reg.nome + "\nMensalidade: " + reg.mensalidadefinal);

            }
            else//não é bolsista
            {
                reg.ehBolsista = false;//manda true para atributo ehBolsista



                reg.calculaMensalidade();//chama o método da classe



                //mostraRegistro ou seja mostra todos os dados da classe
                MessageBox.Show("Nome do aluno: " + reg.nome + "\nMensalidade: " + reg.mensalidadefinal);
            }
        }
    }
}
