using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia
{
    public partial class Form1 : Form
    {
        public string[,] matrizTexto = new string[34,6];
        public string[,] matrizCriptografada = new string[34, 6];
        public string[,] matrizViginere = new string[27,27];
        public string[,] matrizDecriptografada = new string[34, 6];
        public string[] vetorChaveOrdenada = new string[6];
        public string[] vetorChaveDesordenada = new string[6];
        public string[] vetorChaveViginere = new string[200];
        public string[] vetorCifraViginere = new string[200];
        public string[] vetorCifraHomofona = new string[200];
        public string[] vetorCifraDecriptografadaViginere = new string[200];


        /// <summary>
        /// homofona
        /// </summary>
        public string[] vetorTextoDigitado = new string[200];
        public string[] vetorTextoCriptografado = new string[200];
        public string[] vetorTextoViginere = new string[200];
        public string[,] matrizHomofona = new string[6,26];
        public string[] vetorAlfabeto = new string[26];

        

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 34; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    matrizTexto[i, j] = " ";

                }

            }

            tbChave.CharacterCasing = CharacterCasing.Upper;
            tbChaveVigi.CharacterCasing = CharacterCasing.Upper;
            tbEntrada.CharacterCasing = CharacterCasing.Upper;
            tbEntradaHomofona.CharacterCasing = CharacterCasing.Lower;
            tbTextoViginere.CharacterCasing = CharacterCasing.Upper;

            //linha 0 matriz HOMOFONA
            for (int j = 0; j < textBox1.Text.Length; j++)
            {
                
                matrizHomofona[0,j] = textBox1.Text.Substring(j, 1);
               
            }

            //linha 1 matriz HOMOFONA
            for (int j = 0; j < textBox2.Text.Length; j++)
            {
               
                matrizHomofona[1, j] = textBox2.Text.Substring(j, 1);

            }

            //linha 2 matriz HOMOFONA
            for (int j = 0; j < textBox3.Text.Length; j++)
            {
                
                matrizHomofona[2, j] = textBox3.Text.Substring(j, 1);

            }

            //linha 3 matriz HOMOFONA
            for (int j = 0; j < textBox4.Text.Length; j++)
            {
                
                matrizHomofona[3, j] = textBox4.Text.Substring(j, 1);

            }

            //linha 4 matriz HOMOFONA
            for (int j = 0; j < textBox5.Text.Length; j++)
            {
              
                matrizHomofona[4, j] = textBox5.Text.Substring(j, 1);

            }

            //linha 5 matriz HOMOFONA
            for (int j = 0; j < textBox6.Text.Length; j++)
            {
                
                matrizHomofona[5, j] = textBox6.Text.Substring(j, 1);

            }


            for (int i = 0; i < 6; i++)
            {
                string linha = "";

                for (int j = 0; j < 26; j++)
                {
                    linha += matrizHomofona[i, j] + "";
                }

                listBox4.Items.Add(linha);
            }
            
        }
        

        /// <summary>
        ///  CRIAR TABELA COM TODAS AS LETRAS DO ALFABETO
        /// </summary>
        

        private void tbEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Space)
            //{
            //    e.SuppressKeyPress = true;
            //}
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            
            if (tbChave.Text == "" )
            {
                MessageBox.Show("Informe uma chave de criptografia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbChave.Text.Length < 6)
            {
                MessageBox.Show("Informe uma chave de criptografia com 6 digitos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (tbEntrada.Text == "")
            {
                MessageBox.Show("Informe uma frase para ser criptografada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (tbChave.Text.Length != 0)
            {
                string chave = tbChave.Text;
               
                for( int i= 0; i < 1; i++)
                {
                   for(int j = 0; j < tbChave.Text.Length; j++)
                    {
                        //armazena a chave na linha 0 da matriz
                        matrizTexto[i, j] = chave.Substring(j, 1);
                        //preenche o vetor da chave para que possa ser ordenado
                        vetorChaveOrdenada[j] = chave.Substring(j, 1);
                        vetorChaveDesordenada[j] = chave.Substring(j, 1);
                    }
                }


                //ordena o vetor da chave
                StringComparer ordena = StringComparer.OrdinalIgnoreCase;
                Array.Sort(vetorChaveOrdenada, ordena);


                for( int i = 0; i< chave.Length; i++)
                {
                    matrizCriptografada[0, i] = vetorChaveOrdenada[i];
                }                              

            }

            /// VERIFICA SE TEM LETRAS REPETIDAS NA CHAVE
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < tbChave.Text.Length; j++)
                {

                    if (vetorChaveDesordenada[i] == vetorChaveDesordenada[j])
                    {
                        MessageBox.Show("A chave de criptografia não pode ter letras repetidas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }


            if (tbEntrada.Text.Length != 0)
            {               
                //pega cada elemento da frase e preenche a matriz

                int posicao = 0;

                for (int i = 1; i < 34; i++)
                {
                    for( int j = 0; j < 6; j++)
                    {
                        string texto = tbEntrada.Text;

                        if (posicao == texto.Length)
                        {
                            for (int z = 0; z < 34; z++)
                            {
                                string linha = "";

                                for (int w = 0; w < 6; w++)
                                {
                                    linha += matrizTexto[z, w] + "";
                                }

                                listBox1.Items.Add(linha);
                            }
                            geraCriptografia();
                            geraMatrizCriptografada();
                            return;
                        }

                        matrizTexto[i, j] = texto.Substring(posicao, 1);                        
                        posicao++;                     
                        
                    }                                    

                }                              

            }
            
        }
               

        public void geraCriptografia()
        {           

            //pesquisa e lista na matriz por ordem
            string criptografia = "";

            int a = 0, b = 1;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < tbChave.Text.Length; j++)
                {
                    if (vetorChaveOrdenada[i] == matrizTexto[0, j])
                    {
                        for (int z = 1; z < 34; z++)
                        {
                            criptografia += matrizTexto[z, j] + "";
                            matrizCriptografada[b,a] = matrizTexto[z, j];
                            b++;
                        }

                        b = 0;
                        a = a + 1;
                        b = b + 1;                        
                      
                    }
                }
                criptografia += "";
            }

            listBox2.Items.Add(criptografia + "");          
               
        }


        public void geraMatrizCriptografada()
        {
            if (tbEntrada.Text.Length != 0)
            {
                //pega cada elemento da frase e preenche a matriz

                int posicao = 0;

                for (int i = 1; i < 34; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        string texto = tbEntrada.Text;

                        if (posicao == texto.Length)
                        {
                            for (int z = 0; z < 34; z++)
                            {
                                string linha = "";

                                for (int w = 0; w < 6; w++)
                                {
                                    linha += matrizCriptografada[z, w] + "";
                                }

                                listBox6.Items.Add(linha);
                            }

                            return;
                        }

                        posicao++;

                    }

                }

            }
        }



        public void geraMatrizDeCriptografada()
        {
            if (tbEntrada.Text.Length != 0)
            {
                //pega cada elemento da frase e preenche a matriz

                string frasecompleta = "";

                int posicao = 0;

                for (int i = 1; i < 34; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        string texto = tbEntrada.Text;

                        if (posicao == texto.Length)
                        {
                            for (int z = 1; z < 34; z++)
                            {
                                string linha = "";

                                for (int w = 0; w < 6; w++)
                                {
                                    linha += matrizDecriptografada[z, w] + "";
                                }


                                frasecompleta += linha;
                            }
                            listBox7.Items.Add(frasecompleta);
                            return;
                        }


                        posicao++;

                    }

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                   if (vetorChaveDesordenada[i] == matrizCriptografada[0, j])
                    {
                        for (int z = 1; z < 34; z++)
                        {
                            matrizDecriptografada[z, i] = matrizCriptografada[z, j];
                            
                        }
                    }
                }

            }

            geraMatrizDeCriptografada();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 34; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    matrizTexto[i, j] = " ";
                    matrizCriptografada[i, j] = " ";
                    matrizDecriptografada[i, j] = " ";
                    vetorChaveDesordenada[j] = "";
                    vetorChaveOrdenada[j] = "";
                    tbEntrada.Text = "";
                    vetorTextoCriptografado[j] = "";
                    vetorTextoDigitado[j] = "";
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                   // listBox3.Items.Clear();
                    listBox4.Items.Clear();
                  //  listBox5.Items.Clear();
                    listBox6.Items.Clear();
                    listBox7.Items.Clear();

                }

            }
        }

        ////////////////////////////////////////////////HOMOFONA/////////////////////////////////////////////////////////

        public void gerarCriptoHomodona()
        {

            Random posicaoRandomica = new Random();
            int contator = 0;

            if (tbEntradaHomofona.Text.Length != 0)
            {

                for (int i = 0; i < tbEntradaHomofona.Text.Length; i++)
                {

                    vetorTextoDigitado[i] = tbEntradaHomofona.Text.Substring(i, 1);

                }

            }                     


            for( int i = 0;i < tbEntradaHomofona.Text.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if(vetorTextoDigitado[i]==(matrizHomofona[0, j]))
                    {
                        for(int x = 1; x < 6; x++)
                        {
                           
                            if (matrizHomofona[x, j] != "-")
                            {
                                contator++;
                             
                            }
                        }

                        tbCriptografiaHomofona.Text += matrizHomofona[posicaoRandomica.Next(1, contator),j];
                        contator = 0;
                        
                    }
                }
            }           

        }

        private void gerarHomofona_Click(object sender, EventArgs e)
        {
            gerarCriptoHomodona();
        }

        private void tbEntradaHomofona_KeyDown(object sender, KeyEventArgs e)
         {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }

        ////////////////////////////////////////////////VIGINERE/////////////////////////////////////////////////////////

        private void btnGerarTabela_Click(object sender, EventArgs e)
        {


        }


        private void tbTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btnGerarViginere_Click(object sender, EventArgs e)
        {
            if (tbChaveVigi.Text == "")
            {
                MessageBox.Show("Informe uma chave de criptografia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbChaveVigi.Text.Length < 5)
            {
                MessageBox.Show("Informe uma chave de criptografia com 5 digitos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (tbTextoViginere.Text == "")
            {
                MessageBox.Show("Informe uma frase para ser criptografada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }           

            int linha= 0 , coluna = 0;

            gerarMatrizviginere();

            // CRIA UM VETOR COMO A CHAVE DE CRIPTOGRAFIA
            if (tbChaveVigi.Text.Length != 0)
            {
                string chaveVIGI = tbChaveVigi.Text;

                int z = 0;

                for (int i = 0; i < tbTextoViginere.Text.Length; i++)
                {
                    //preenche o vetor da chave com o tamanho do texto digitado
                    vetorChaveViginere[i] = chaveVIGI.Substring(z, 1);
                    z++;
                    if(z == 5)
                    {
                        z = 0;
                    }

                }
                
            }

            // CRIA UM VETOR COM O TEXTO DIGITADO
            if (tbChaveVigi.Text.Length != 0)
            {
                string textoViginere = tbTextoViginere.Text;

                for (int i = 0; i < tbTextoViginere.Text.Length; i++)
                {
                    //preenche o vetor da chave 
                    vetorTextoViginere[i] = textoViginere.Substring(i, 1);

                }

                //VERIFICA SE TEM LETRAS REPETIDAS
                for (int i = 0; i < 5; i++)
                {
                    for (int j = i +1 ; j < tbChaveVigi.Text.Length; j++)
                    {

                        if (vetorChaveViginere[i] == vetorChaveViginere[j])
                        {
                            MessageBox.Show("A chave de criptografia não pode ter letras repetidas!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

            }            

            //PROCURA COLUNA E LINHA
            for (int i = 0; i < tbTextoViginere.Text.Length; i++)
            {
                for( int j = 1; j < 27; j++)
                {

                    if (vetorTextoViginere[i] ==  matrizViginere[0, j])
                    {

                        coluna = j;

                    }

                    if (vetorChaveViginere[i] == matrizViginere[j, 0])
                    {

                        linha = j;
                        
                    }

                }

                vetorCifraViginere[i] = matrizViginere[linha, coluna];

            }

          for(int i= 0; i< tbTextoViginere.Text.Length; i++)
            {
                tbResultadoCriptografia.Text += vetorCifraViginere[i];
            }
        }         

        public void gerarMatrizviginere()
        {
           
            //alfabeto
            vetorAlfabeto[0] = "A";
            vetorAlfabeto[1] = "B";
            vetorAlfabeto[2] = "C";
            vetorAlfabeto[3] = "D";
            vetorAlfabeto[4] = "E";
            vetorAlfabeto[5] = "F";
            vetorAlfabeto[6] = "G";
            vetorAlfabeto[7] = "H";
            vetorAlfabeto[8] = "I";
            vetorAlfabeto[9] = "J";
            vetorAlfabeto[10] = "K";
            vetorAlfabeto[11] = "L";
            vetorAlfabeto[12] = "M";
            vetorAlfabeto[13] = "N";
            vetorAlfabeto[14] = "O";
            vetorAlfabeto[15] = "P";
            vetorAlfabeto[16] = "Q";
            vetorAlfabeto[17] = "R";
            vetorAlfabeto[18] = "S";
            vetorAlfabeto[19] = "T";
            vetorAlfabeto[20] = "U";
            vetorAlfabeto[21] = "V";
            vetorAlfabeto[22] = "W";
            vetorAlfabeto[23] = "X";
            vetorAlfabeto[24] = "Y";
            vetorAlfabeto[25] = "Z";



            // PONTO EM BRANCO DA MATRIZ
            matrizViginere[0, 0] = "  ";

            //PREENCHE A PRIMEIRA LINHA
            for (int i = 1; i < 27; i++)
            {
                matrizViginere[0, i] = vetorAlfabeto[i - 1];
            }

            //PREENCHE A PRIMEIRA COLUNA
            for (int j = 1; j < 27; j++)
            {
                matrizViginere[j, 0] = vetorAlfabeto[j - 1];
            }

            // PREENCHE O RESTANTE DA MATRIZ
            int z = 0;

            for (int i = 1; i < 27; i++)
            {
                

                for (int j = 1; j < 27; j++)
                {

                    matrizViginere[i, j] = vetorAlfabeto[z];
                    z++;

                    if (z == 26)
                    {
                        z = 0;
                    }

                }
                z++;
            }


            // IMPRIME MATRIZ 
            for (int i = 0; i < 27; i++)
            {
                string linha = "";

                for (int j = 0; j < 27; j++)
                {
                    linha += matrizViginere[i, j] + " ";
                }

                listBox8.Items.Add(linha);
            }

        }

        private void btnDecriptaViginere_Click(object sender, EventArgs e)
        {
            
            if (tbResultadoCriptografia.Text == "")
            {
                MessageBox.Show("Informe uma frase para ser Decriptografada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int linha = 0;

            for (int i = 0; i < tbTextoViginere.Text.Length; i++)
            {
                for (int j = 0; j < 27; j++)
                {
                    if(vetorChaveViginere[i] == matrizViginere[j,0])
                    {
                        linha = j;

                        for( int z= 1; z < 27; z++)
                        {
                            if(vetorCifraViginere[i] == matrizViginere[linha, z])
                            {
                                vetorCifraDecriptografadaViginere[i] = matrizViginere[0, z];
                            }
                        }                        
                    }     
                }
                
            }            

            for (int i = 0; i < tbTextoViginere.Text.Length; i++)
            {
                tbFraseDecriptografada.Text += vetorCifraDecriptografadaViginere[i];
            }
        }

        private void btnLimparDados_Click(object sender, EventArgs e)
        {
            tbChaveVigi.Text = "";
            tbTextoViginere.Text = "";
            tbResultadoCriptografia.Text = "";
            tbFraseDecriptografada.Text = "";
            listBox8.Items.Clear();
        }

        private void btnDecriptaHomofona_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < tbCriptografiaHomofona.Text.Length; j++)
            {                                
                vetorCifraHomofona[j] = tbCriptografiaHomofona.Text.Substring(j, 1);
                
            }
                        
              for (int z = 0; z < tbEntradaHomofona.Text.Length; z++)

              for (int i = 1; i < 6; i++)
              {
                 for (int j = 0; j < 26; j++)
                 {
                      if (vetorCifraHomofona[z] == matrizHomofona[i, j])
                       {
                         tbHomofonaDecriptografada.Text += matrizHomofona[0, j];
                       }
                 }
              }

        }

        private void tbChaveVigi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbChave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Letras!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
