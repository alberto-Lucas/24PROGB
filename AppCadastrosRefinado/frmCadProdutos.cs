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
    public partial class frmCadProdutos : Form
    {
        public frmCadProdutos()
        {
            InitializeComponent();
            //Desabilitar o AutoValidate
            AutoValidate = AutoValidate.Disable;

            //Após a execução
            //Irei aplicar um foco no campo
            //Descrição
            //Utilizando o método
            //Focus();

            txtDescricao.Focus();
        }

        //Criar blocos de codigo,  por region
        //onde essa região pode ser oculta(recolhida)
        // ou pode ser exibidar
        //utilizando a palavra reservada region, seguinda do #

        //aqui foi criado um bloco de regiao
        #region Teste
        //codigo a ser recolhido
        #endregion

        #region Evento KeyDown
        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            //Evento só vai ser disparado
            //ao soltar uma tecla depois
            //de ser pressionada
            //enquanto a tecla estiver
            //pressionada o evento não é disparado.

            //Identificar qual tecla
            //esta sendo pressionada
            if (e.KeyCode == Keys.Enter)
            {
                //Caso o ENTER for pressionado
                //iremos definir o foco
                //para o proximo campo
                txtCodBarras.Focus();
            }
        }

        private void txtCodBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboUN.Focus();
                //Comando para abrir
                //a lista de itens
                //do combobox
                cboUN.DroppedDown = true;
            }
        }

        private void cboUN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboGrupo.Focus();
                cboGrupo.DroppedDown = true;
            }
        }

        private void cboGrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrateleira.Focus();
            }
        }

        private void txtPrateleira_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPrecoVenda.Focus();
            }
        }

        private void txtPrecoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }
        #endregion

        #region Eventos KeyPress
        private void txtCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Iremos validar o pressionamento
            //das teclas, para aceitar
            //somente numeros

            //coletar o caracter da tecla
            char ch = e.KeyChar;

            //O ch recebe o carecter pressionado
            //com base na tabela ASCII

            //Carcteres uteis:
            //BackSpace = 8
            //Enter = 13

            //agora iremos validar o caracter
            if(!char.IsDigit(ch) &&
                ch != 8 &&
                ch != 13)
            {
                //se identificarmos
                //que esta sendo pressionada
                //uma tecla que nao deveria
                //precisamos cancelar o 
                //precionamento

                //Cancelando o evento 
                //de pressionametno
                e.Handled = true;
                MessageBox.Show(
                    "Este campo aceita "+
                    "apenas números",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //Iremos validar o valor do tipo moeda
            //Ou seja deve-se aceitar a virgula

            if(!char.IsDigit(ch) &&
                ch != 8 &&
                ch != 13 &&
                ch != ',')
            {
                e.Handled= true;
                MessageBox.Show(
                        "Este campo aceita " +
                        "apenas números e "+
                        "virgulas",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        private void txtDescricao_Validating(object sender, CancelEventArgs e)
        {
            //Validar se o campo, descrição
            //esta preenchido

            if(string.IsNullOrEmpty(txtDescricao.Text))
            {
                //Gerar a notificação para o usuario
                e.Cancel = true;
                errorProvider1.SetError(
                    txtDescricao, 
                    "Informe a descrição do Produto");
            }
            else
            {
                //Desabilitar a notificação
                //Quando o campo for preenchido
                e.Cancel= false;
                errorProvider1.SetError(
                    txtDescricao,
                    "");
            }
        }

        private void txtCodBarras_Validating(object sender, CancelEventArgs e)
        {
            //Primeiro validamos se o
            //campo esta preenchido
            if(string.IsNullOrEmpty(txtCodBarras.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    txtCodBarras,
                    "Informe o Código de Barras");
            }
            else
            {
                //se estiver prenchido
                //irtemos validar a quantidade de 
                //numero
                //CÓDIGO DE BARRAS aceita apenas
                //13 caractres

                //Se o campo txtCidBarras possuir
                //um quantidade de caracteres 
                //diferente de 13, gerar notificação
                if(txtCodBarras.Text.Count() != 13)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(
                        txtCodBarras, 
                        "Informe o Código de Barras "+
                        "com 13 digitos");
                }
                else
                {
                    //Se estiver tudo certo
                    //Cancelar a notificação
                    e.Cancel = false;
                    errorProvider1.SetError(
                        txtCodBarras, "");
                }
            }
        }

        private void cboUN_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(cboUN.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    cboUN, 
                    "Selecione uma Unidade.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(
                    cboUN, "");
            }
        }

        private void cboGrupo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cboGrupo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(
                    cboGrupo,
                    "Selecione uma Unidade.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(
                    cboGrupo, "");
            }
        }

        private void txtPrecoVenda_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPrecoVenda.Text))
            {
                e.Cancel= true;
                errorProvider1.SetError(
                    txtPrecoVenda,
                    "Informe o Preço de Venda.");
            }
            else
            {
                float valor = 
                    float.Parse(txtPrecoVenda.Text);

                if(valor <= 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(
                        txtPrecoVenda,
                        "O preço de venda deve "+
                        "ser mario que zero");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(
                        txtPrecoVenda, "");
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidateChildren
                (ValidationConstraints.Enabled))
            {
                MessageBox.Show(
                    "Registro salvo com Sucesso!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();
            }
            else
            {
                MessageBox.Show(
                    "É nescessario o preenchimento "+
                    "correto de todos os campos.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(
                "Deseja realmente descartar as alterações?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == 
                DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
