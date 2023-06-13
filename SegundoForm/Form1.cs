using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbResultado.Text = "";
            lbFalse.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = txNome.Text;
            string cpf = txCpf.Text;
            int idade = Convert.ToInt32(numIdade.Text);
            string sexo = cmbSexo.Text;
            double peso = Convert.ToDouble(numPeso.Text);
            double altura = Convert.ToDouble(numAltura.Text);

            Pessoa p = new Pessoa(nome, cpf, idade, sexo, peso, altura);

            (double imc, string classificacao, string grau) = p.CalcularImc();
            lbResultado.Text = $" Seu imc é {imc.ToString("0.00")} \n Sua classificação é: {classificacao} \n Seu grau é: {grau}";

            
           
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txNome.Clear();
            txCpf.Clear();
            numIdade.ResetText();
            cmbSexo.ResetText();
            numPeso.ResetText();
            numAltura.ResetText();

            lbResultado.Text = "";
            lbFalse.Text = "";
     
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CadastroCliente cliente = new CadastroCliente();
            cliente.ShowDialog();
        }

        private void txCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
