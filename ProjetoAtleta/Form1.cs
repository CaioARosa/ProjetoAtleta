using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtleta
{
    public partial class Frm_pessoa : Form
    {
        public Frm_pessoa()
        {
            InitializeComponent();
        }

        Pessoa obj = new Pessoa();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Nome = txtNome.Text;
                obj.DataNascimento = DateTime.Parse(txtDataNascimento.Text);
                obj.Altura = double.Parse(txtAltura.Text);
                MessageBox.Show("Dados armazenados.");
            }
            catch(FormatException erro)
            {
                MessageBox.Show("O formulário possui campos estão preenchidos " +
                    "incorretamente.Verifique o erro. \n " + erro.Message);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message+ "\n"+ erro.GetType());
            }
        }

        private void btnIdade_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados obtidos:  " + obj.ImprimeDados() +
                            "\n\nIdade: " + obj.CalcularIdade().ToString("00"));
                txtIdade.Text = obj.CalcularIdade().ToString();
        }
    }
}
