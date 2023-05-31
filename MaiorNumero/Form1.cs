using System;
using System.Windows.Forms;

namespace MaiorNumero
{
    public partial class Form1 : Form
    {
        public int VerificaMaior(int num1, int num2)
        {
            if (num1 > num2)
                return num1;
            else return num2;
        }

        void LimparControles()
        {
            txtA.Clear();
            txtB.Clear();
            txtMaior.Clear();
            txtA.Focus();
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, System.EventArgs e)
        {
            //Declaração das Variáveis
            int a, b;

            //Entrada de Dados para as Variáveis
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);

            //Chamar a função VerificaMaior e passar os parâmetros
            //num1 e num2

            txtMaior.Text = VerificaMaior(a, b).ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparControles();
        }
    }
}