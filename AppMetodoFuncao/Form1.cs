using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMetodoFuncao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIF_Click(object sender, EventArgs e)
        {
            string opcao;

            if (cbxOpcao.SelectedIndex == 0)
                opcao = "Opção 1 selecionada";
            else if (cbxOpcao.SelectedIndex == 1)
                opcao = "Opção 2 selecionada";
            else if (cbxOpcao.SelectedIndex == 2)
                opcao = "Opção 3 selecionada";
            else if (cbxOpcao.SelectedIndex == 3)
                opcao = "Opção 4 selecionada";
            else
                opcao = "Nenhum opção";

            MessageBox.Show(opcao);
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            string opcao;

            switch(cbxOpcao.SelectedIndex)
            {
                case 0:
                    opcao = "Opção 1";
                    break;
                case 1:
                    opcao = "Opção 2";
                    break;
                case 2:
                    opcao = "Opção 3";
                    break;
                case 3:
                    opcao = "Opção 4";
                    break;
                default:
                    opcao = "Nenhuma";
                    break;
            }

            MessageBox.Show(opcao);
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            MetodoSomar();
        }

        void MetodoSomar()
        {
            int v1, v2, resultado;

            v1 = int.Parse(txtV1.Text);
            v2 = int.Parse(txtV2.Text);

            resultado = v1 + v2;

            MessageBox.Show("A soma é: " 
                 + resultado.ToString());
        }

        private void btnFuncao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A soma é: " +
                FuncaoSomar().ToString());
        }

        int FuncaoSomar()
        {
            int v1, v2;

            v1 = int.Parse(txtV1.Text);
            v2 = int.Parse(txtV2.Text);

            return v1 + v2;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Resultado é:" +
                Calcular(
                    int.Parse(txtV1.Text),
                    int.Parse(txtV2.Text),
                    txtOperador.Text
                    ).ToString());
        }

        int Calcular(int v1, int v2, string operador)
        {
            switch(operador)
            {
                case "+": return v1 + v2;
                case "-": return v1 - v2;
                case "*": return v1 * v2;
                case "/": return v1 / v2;
                default: return 0;
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O resultado é: " +
                Calcular(
                    int.Parse(txtV1.Text),
                    int.Parse(txtV2.Text),
                    "+"
                    ).ToString());
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Resultado é:" +
               Calcular(2, 5, "*").ToString());
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lstFor.Items.Clear();

            for (int i = 0; i <= 10; i++)
                lstFor.Items.Add(i.ToString());
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            bool condicao;

            condicao =
                    MessageBox.Show(
                        "O Lucas é o melhor Professor?",
                        "Pergunta",
                        MessageBoxButtons.YesNo)
                    == DialogResult.Yes;

            while (!condicao)
            {
                condicao =
                    MessageBox.Show(
                        "O Lucas é o melhor Professor?",
                        "Pergunta",
                        MessageBoxButtons.YesNo)
                    == DialogResult.Yes;
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            bool condicao;

            do
            {
                condicao =
                    MessageBox.Show(
                        "O Lucas é o melhor Professor?",
                        "Pergunta",
                        MessageBoxButtons.YesNo)
                    == DialogResult.Yes;
            }
            while (!condicao);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            MudarBotao();
        }

        void MudarBotao()
        {
            Random random = new Random();

            int x, y;

            y = random.Next(0, this.Height - btnNao.Height);
            x = random.Next(0, this.Width - btnNao.Width);

            btnNao.Left = x;
            btnNao.Top = y;
        }
    }
}
