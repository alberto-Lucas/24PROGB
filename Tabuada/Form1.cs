using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        //Aceitar apenas numeros
        //Aceitar numero
        //maior que 0 e menor que 100
        //Validar se o numero final
        //é maior que o numero inicial
        public Form1()
        {
            InitializeComponent();
        }

        //Função que retorna se o valor é um numero
        bool IsNumero(string valor)
        {
            //Validar se o parametro esta vazio
            if (valor == "")
                return false;

            //Criar um laço de repaetição
            //que passara por cada caracter
            //validando se é um numero
            for (int i = 0; i < valor.Length; i++)
            {
                //Validar se o caracter é numero
                //OU seja ele precisa ser um Digit
                //Se não for digit não é um numero
                if (!char.IsDigit(valor[i]))
                    return false;
            }

            //Quando aqui
            //ja tenho a certeza que o meu valor
            //é um numero, entao retorno verdadeiro
            return true;
        }

        //Funação para validar os campos
        bool IsCamposValidos()
        {
            //Sera validado os 2 campos em tela
            //Se o Numero Inicial e Final
            //são apenas numeros
            if (IsNumero(txtNumInicial.Text))
            {
                if(IsNumero(txtNumFinal.Text))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(
                        "Informe um número Final válido");
                    return false;
                }
            }
            else
            {
                MessageBox.Show(
                    "Informe um número Inicial válido");
                return false;
            }
        }

        //Função para validar se o numero
        //informa é > 0 e menor que 100
        bool IsIntervaloValido(int valor)
        {
            /*
            if(valor > 0 && valor < 100)
                return true;
            else
                return false;
            */

            return (valor > 0 && valor < 100);
        }

        //Função para validar o
        //intervalo dos valores
        bool IsValoresValidos(int valor1, int valor2)
        {
            //Primeiro valido o valor
            //estra dentro do intervalo
            if (IsIntervaloValido(valor1))
            {
                if (IsIntervaloValido(valor2))
                {
                    if (valor2 > valor1)
                        return true;
                    else
                    {
                        MessageBox.Show(
                            "O número Final deve ser maior " +
                            "que o número Incial.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Informa um número Final maior" +
                        "que zero(0) e menor que cem(100).");
                    return false;
                }
            }
            else
            {
                MessageBox.Show(
                    "Informa um número Inicial maior" +
                    "que zero(0) e menor que cem(100).");
                return false;
            }
        }

        //Método para calcular a tabuada
        void Tabuada(int vInicial, int vFinal)
        {
            //Crio um laço de repetição que ira
            //passar por cada valor do intervalo
            //Ou seja temos o intervalo do 2 ao 4
            //Então iremos paassar pelo 2
            //depois pelo 3 e por ultimo pelo 4
            for(int i = vInicial; i <= vFinal; i++)
            {
                //A cada passada do intervalo iremos 
                //calcular a tabuada do intervalod de 1 a 10
                //Ou seja se for intervalo do 3
                //Iremos calcular a tabuado do 3 do 1 ao 10
                for(int j = 1; j <= 10; j++)
                {
                    string resultado;

                    //Ex: 2 x 5 = 10
                    //Ex: 2
                    //Quero 0 caracteres
                    //Adicionar zero a esquerda
                    //Ex: 02
                    resultado = i.ToString("00") + " x " +
                        j.ToString("00") + " = " +
                        (i * j).ToString("00");

                    lstResultado.Items.Add(resultado);
                }
                lstResultado.Items.Add("------------");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Validar se os valores inserido
            //são validos
            if(IsCamposValidos())
            {
                //Como todos os valores são numero
                //podemos converter o string para int
                int numInicial, numFinal;

                numInicial = 
                    int.Parse(txtNumInicial.Text);
                numFinal =
                    int.Parse(txtNumFinal.Text);

                //Agora iremos validar os intervalos
                if(IsValoresValidos(numInicial, numFinal))
                {
                    //Se chegamos até aqui, todos os valores
                    //estão corretos e válidos
                    //Podemos calcular a tabuada

                    //Primeiro precisamos limpar o listbox
                    lstResultado.Items.Clear();

                    //Chamamos o método para calcular a tabuada
                    Tabuada(numInicial, numFinal);
                }
            }
        }

        //Essas 2 ultimas chaves são padroes
        //Crie seus métodos, funções e variaveis
        //acima dessas chave
    }
}
