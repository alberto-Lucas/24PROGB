using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTipoDadosB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = int.Parse(textBox1.Text);

            MessageBox.Show(
               "Vc é: " +
                (idade >= 18 ? "maior de idade" : "menor de idade"));
        }

        private void btnProcessarBebida_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vc bebe?: " + (ckbBebe.Checked ? "SIM" : "NÃO"));
        }

        private void ckbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtLogin.UseSystemPasswordChar =
                !ckbMostrarSenha.Checked;

            if (ckbMostrarSenha.Checked)
                txtLogin.UseSystemPasswordChar = false;
            else
                txtLogin.UseSystemPasswordChar = true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            /*
            if (txtUsuario.Text == "admin")
            {
                if (txtLogin.Text == "admin")
                    MessageBox.Show("Bem vindo");
                else
                    MessageBox.Show("Senha invalida");
            } 
            else
            {
                MessageBox.Show("Usuario invalido");
            }*/

            if (txtUsuario.Text == "admin" &&
                txtLogin.Text == "admin")
                MessageBox.Show("Bem vindo");
            else
                MessageBox.Show("Usuario ou senha invalidos");
        }
    }
}
