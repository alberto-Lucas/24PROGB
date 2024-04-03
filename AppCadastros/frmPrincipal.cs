using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCadastros
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmPrincipal_FormClosing(
            object sender, FormClosingEventArgs e)
        {
            //Validar se o usuario
            //deseja realmente fechar o sistema

            if (MessageBox.Show(
                "Deseja sair?",
                "Atenção!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
                ) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToShortDateString();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Para chamar uma nova tela
            //é preciso criar uma nova isntancia
            //em memoria
            //Utilizamos a palavra reservada new
            //com isso criamos uma instancia em 
            //memoria
            //Iremos criar uma vairiavel
            //do tipo frmCadClientes
            //Depois iremos atribuir a instancia 
            //a variavel
            //e por ultimo exibir a tela
            frmCadClientes frm =
                new frmCadClientes();

            //Possuimo o 
            //Show() iremos carregar a tela de
            //independente

            //ShowDialog() que sera presa
            //a tela anterior
            frm.ShowDialog();
        }
    }
}
