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
    public partial class frmCadClientes : Form
    {
        public frmCadClientes()
        {
            //Serve para criar o visual
            //da tela
            //Ou seja ira renderizar o 
            //formulario
            InitializeComponent();

            //Nescessario para que o sistema
            //não dispare a validação a todo
            //momento
            AutoValidate = AutoValidate.Disable;
        }

        private void txtNomeCompleto_Validating(object sender, CancelEventArgs e)
        {
            //Validar o campo txtNomeCompleto
            //Se está vazio

            if(string.IsNullOrEmpty(
                txtNomeCompleto.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtNomeCompleto,
                    "Preencha o Nome.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(
                    txtNomeCompleto,
                    "");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(
                ValidationConstraints.Enabled))
            {
                MessageBox.Show(
                    "Registro Salvo com sucesso!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Preencha todos os campos corretamente",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void mskCPF_Validating(object sender, CancelEventArgs e)
        {
            string numero = "";

            //A mascara ira retornar as pontuaçãos
            //Ex: 123.456.789-00
            //Porem precisamos apenas do numeros
            foreach(char c in mskCPF.Text)
            {
                if (char.IsDigit(c))
                    numero += c;
            }

            //Vaidar se o campo está vazio
            if(string.IsNullOrEmpty(numero))
            {
                e.Cancel= true;
                errorProvider1.SetError(
                    mskCPF, "Preencha o CPF.");
            }
            //Validar a quantidade de digitos
            else if (numero.Length != 11)
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    mskCPF, 
                    "Preencha o CPF corretamente.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(
                    mskCPF, "");
            }
        }
    }
}
