using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Servico s = new Servico();
            
            double saldo = s.Saldo(textBox1.Text, textBox2.Text);
            MessageBox.Show(saldo.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Servico s = new Servico();

            bool deposito = s.Deposito(Double.Parse(textBox4.Text), textBox3.Text);
            MessageBox.Show("Deposito Realizado com Sucesso");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Servico s = new Servico();
            bool saque = s.Saque(Double.Parse(textBox6.Text), textBox5.Text);
            MessageBox.Show("Saque Realizado com Sucesso");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Servico s = new Servico();
            bool cadastrar = s.CadastrarUsuario(textBox7.Text, textBox8.Text, textBox9.Text);
            MessageBox.Show("Cadastro Realizado com Sucesso");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Servico s = new Servico();
            bool alterar = s.AlterarCadastro(textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text);
            MessageBox.Show("Alterado com Sucesso");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Servico s = new Servico();
            string consultar = s.ConsultarConta(textBox14.Text, textBox15.Text);
            MessageBox.Show(consultar);
        }
    }
}
