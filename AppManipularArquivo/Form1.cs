using System;
using System.IO;
using System.Windows.Forms;

namespace AppManipularArquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //Utilizando o compoenten FolderBrowser
            //Iremos apresentar a tela de
            //selação de pastas para o usuario
            //e iremos coletar o resultada da seleção
            DialogResult resultado = 
                folderBrowserDialog1.ShowDialog();

            //Verificamos se foi selecionado ou nao
            //um diretorio
            //Se clicado em cancelar, iremos ignorar
            //Se clicado no ok, iremos
            //validar o diretorio selecionado
            //se tudo estiver ok, iremos apresentar
            //o diretorio em tela no textbox
            if(resultado == DialogResult.OK &&
                !string.IsNullOrWhiteSpace(
                    folderBrowserDialog1.SelectedPath))
            {
                txtCaminho.Text = 
                    folderBrowserDialog1.SelectedPath;
            }
        }

        //Função para validar o diretorio
        bool ValidarDiretorio()
        {
            //Recuper os dados informados
            //pelo usuario
            string diretorio = txtCaminho.Text;
            string nomeArquivo = txtNomeArquivo.Text;

            //Validar o preenchimento dos campos
            if(string.IsNullOrEmpty(diretorio) ||
                string.IsNullOrEmpty(nomeArquivo))
            {
                MessageBox.Show(
                    "Pro favor, selecione um diretório "+
                    "e informe um nom e de arquivo.");

                return false;
            }

            //Validar se o diretorio é valido
            //Para utilizar o Directory
            //é preciso imporatar a biblioteca:
            //using System.IO;
            if(!Directory.Exists(diretorio))
            {
                MessageBox.Show(
                    "O diretório especificado "+
                    "não existe.");

                return false;
            }

            //Se chegou até, está tudo ok
            return true;
        }

        //Função para retorna o diretorio completo
        string GetDiretorioCompleto()
        {
            //Diretorio + Nome Arquivo + extensão
            //Retornando no formato de diretorio
            //Ex: c:\pasta\arquivo.txt
            //Ex caminho: c:\pasta
            //Ex nome: arquivo
            //Ex Extensão: .txt
            return Path.Combine(
                txtCaminho.Text,
                txtNomeArquivo.Text + ".txt");
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            //Validamos os dados do diretorio
            //Se for falso interrompo a execução
            if (!ValidarDiretorio())
                return; //para tudo

            string caminhoCompleto = 
                GetDiretorioCompleto();

            //Verificar se o arquivo existe
            if(File.Exists(caminhoCompleto))
            {
                MessageBox.Show("O arquivo já existe");
            }
            else
            {
                //Iremos criar um arquivo vazio
                File.WriteAllText(caminhoCompleto, "");

                MessageBox.Show(
                    "Arquivo criado com sucesso!");
            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Primeiro a validação
            if(!ValidarDiretorio())
                return;

            //Recupera o caminha configurado
            string caminhoCompleto =
                GetDiretorioCompleto();

            //Gravar o conteudo o textBox no arquivo
            //Todo o conteudo do arquivo
            //será subistituido
            File.WriteAllText(caminhoCompleto, 
                txtTexto.Text +
                Environment.NewLine);

            MessageBox.Show("Dados gravados com sucesso!.");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(!ValidarDiretorio())
                return;

            string caminhoCompleto =
                GetDiretorioCompleto();

            //Agora iremos adicionar o texto no arquivo
            //Ou seja sera mantido o conectudo atual do 
            //arquivo e adicionado ao final o novo conteduo
            //Adionar uma quebra de linha
            //Environment.NewLine

            File.AppendAllText(
                caminhoCompleto, txtTexto.Text + 
                Environment.NewLine);

            MessageBox.Show("Dados adicionados com sucesso!.");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if(!ValidarDiretorio())
                return;

            string caminhoCompleto = GetDiretorioCompleto();

            if(File.Exists(caminhoCompleto))
            {
                //Ler o arquivo, e apresentar o 
                //conteudo no textBox
                txtArquivo.Text = 
                    File.ReadAllText(caminhoCompleto);
                MessageBox.Show(
                    "Conteúdo carregado com sucesso!");
            }
            else
            {
                MessageBox.Show(
                    "O arquivo não existe.");
            }
        }
    }
}
