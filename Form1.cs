using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Termoo
{
    public partial class Form1 : Form
    {
        private char status = 'D';
        public void ComecarJogo()//SetStatus
        {
            status = 'A';
        }
        public char GetStatus()
        {
            return status;
        }
        private string palavra;
        public string GetPalavra()
        {
            return palavra;
        }
        public void SetPalavra(string palavra)
        {
            this.palavra = palavra;
        }
        private int vidas = 10;
        public int GetVidas()
        {
            return vidas;
        }
        public void ResetaVidas()
        {
            vidas = 5;
        }
        public int TiraVida()
        {
            return --vidas;
        }
        private string Palavra()
        {
            string palavra;
            Random rnd = new Random();
            Dictionary<int, string> pal = new Dictionary<int, string>();
            pal.Add(0, "A r r o z");
            pal.Add(1, "P e i x e");
            pal.Add(2, "T e s t e");
            pal.Add(3, "P a r i s");
            pal.Add(4, "P e n i s");
            pal.Add(5, "B a r c o");
            pal.Add(6, "L o u c a");
            pal.Add(7, "F r u t a");
            pal.Add(8, "A m o r a");
            pal.Add(9, "M a n g a");
            pal.Add(10, "J a m b o");
            pal.Add(11, "B a n c o");
            pal.Add(12, "C i n z a");
            pal.Add(13, "P r e t o");
            pal.Add(14, "T i g r e");
            pal.Add(15, "T r i g o");
            pal.Add(16, "F u n g o");
            pal.Add(17, "L i m a o");
            pal.Add(18, "M e l a o");
            pal.Add(19, "G l o c k");
            pal.Add(20, "M a m a o");
            pal.Add(21, "G a r c a");
            pal.Add(22, "P a n d a");
            pal.Add(23, "C u r s o");
            pal.Add(24, "P o m b o");
            pal.Add(25, "P a r d o");
            pal.Add(26, "P a d r e");
            pal.Add(27, "P r a t o");
            pal.Add(28, "C a m p o");
            pal.Add(29, "P r a d o");
            pal.Add(30, "P o r t a");

            int num = rnd.Next(30);
            pal.TryGetValue(num, out palavra);

            return palavra;
        }
        public void LimpaTbChute()
        {
            tb_Chute1.Clear();
            tb_Chute2.Clear();
            tb_Chute3.Clear();
            tb_Chute4.Clear();
            tb_Chute5.Clear();
        }
        public void LimpaTbPalavra()
        {
            tb_Palavra1.Clear();
            tb_Palavra2.Clear();
            tb_Palavra3.Clear();
            tb_Palavra4.Clear();
            tb_Palavra5.Clear();
            tb_Palavra6.Clear();
            tb_Palavra7.Clear();
            tb_Palavra8.Clear();
            tb_Palavra9.Clear();
            tb_Palavra10.Clear();
            tb_Palavra11.Clear();
            tb_Palavra12.Clear();
            tb_Palavra13.Clear();
            tb_Palavra14.Clear();
            tb_Palavra15.Clear();
            tb_Palavra16.Clear();
            tb_Palavra17.Clear();
            tb_Palavra18.Clear();
            tb_Palavra19.Clear();
            tb_Palavra20.Clear();
            tb_Palavra21.Clear();
            tb_Palavra22.Clear();
            tb_Palavra23.Clear();
            tb_Palavra24.Clear();
            tb_Palavra25.Clear();

            tb_Palavra1.BackColor = Color.White;
            tb_Palavra2.BackColor = Color.White;
            tb_Palavra3.BackColor = Color.White;
            tb_Palavra4.BackColor = Color.White;
            tb_Palavra5.BackColor = Color.White;
            tb_Palavra6.BackColor = Color.White;
            tb_Palavra7.BackColor = Color.White;
            tb_Palavra8.BackColor = Color.White;
            tb_Palavra9.BackColor = Color.White;
            tb_Palavra10.BackColor = Color.White;
            tb_Palavra11.BackColor = Color.White;
            tb_Palavra12.BackColor = Color.White;
            tb_Palavra13.BackColor = Color.White;
            tb_Palavra14.BackColor = Color.White;
            tb_Palavra15.BackColor = Color.White;
            tb_Palavra16.BackColor = Color.White;
            tb_Palavra17.BackColor = Color.White;
            tb_Palavra18.BackColor = Color.White;
            tb_Palavra19.BackColor = Color.White;
            tb_Palavra20.BackColor = Color.White;
            tb_Palavra21.BackColor = Color.White;
            tb_Palavra22.BackColor = Color.White;
            tb_Palavra23.BackColor = Color.White;
            tb_Palavra24.BackColor = Color.White;
            tb_Palavra25.BackColor = Color.White;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (GetStatus() == 'A')//valida se o jogador clicou em comecar
            {
                string nPalavra = "";
                string palavra = GetPalavra();
                int i = 0;
                string[] pal = new string[5];
                foreach (string s in palavra.Split(' '))
                {
                    pal[i] = s;
                    nPalavra += s;
                    i++;
                }
                if (GetVidas() > 0)
                {
                    if (tb_Chute1.Text == "" || tb_Chute2.Text == "" || tb_Chute3.Text == "" || tb_Chute4.Text == "" || tb_Chute5.Text == "")//valida campo de chute vazio
                    {
                        tb_Chute1.Focus();
                        MessageBox.Show("Digite uma palavra");
                        return;
                    }
                    int j = 0;
                    foreach (string s in palavra.Split(' '))
                    {
                        pal[j] = pal[j].ToUpper();
                        j++;
                    }
                    tb_Chute1.Text = tb_Chute1.Text.ToUpper();
                    tb_Chute2.Text = tb_Chute2.Text.ToUpper();
                    tb_Chute3.Text = tb_Chute3.Text.ToUpper();
                    tb_Chute4.Text = tb_Chute4.Text.ToUpper();
                    tb_Chute5.Text = tb_Chute5.Text.ToUpper();
                    if (GetVidas() == 5)//verifica em qual TextBox ira a letra
                    {
                        tb_Palavra1.Text = tb_Chute1.Text;
                        tb_Palavra2.Text = tb_Chute2.Text;
                        tb_Palavra3.Text = tb_Chute3.Text;
                        tb_Palavra4.Text = tb_Chute4.Text;
                        tb_Palavra5.Text = tb_Chute5.Text;
                    }
                    else if (GetVidas() == 4)
                    {
                        tb_Palavra6.Text = tb_Chute1.Text;
                        tb_Palavra7.Text = tb_Chute2.Text;
                        tb_Palavra8.Text = tb_Chute3.Text;
                        tb_Palavra9.Text = tb_Chute4.Text;
                        tb_Palavra10.Text = tb_Chute5.Text;
                    }
                    else if (GetVidas() == 3)
                    {
                        tb_Palavra11.Text = tb_Chute1.Text;
                        tb_Palavra12.Text = tb_Chute2.Text;
                        tb_Palavra13.Text = tb_Chute3.Text;
                        tb_Palavra14.Text = tb_Chute4.Text;
                        tb_Palavra15.Text = tb_Chute5.Text;
                    }
                    else if (GetVidas() == 2)
                    {
                        tb_Palavra16.Text = tb_Chute1.Text;
                        tb_Palavra17.Text = tb_Chute2.Text;
                        tb_Palavra18.Text = tb_Chute3.Text;
                        tb_Palavra19.Text = tb_Chute4.Text;
                        tb_Palavra20.Text = tb_Chute5.Text;
                    }
                    else if (GetVidas() == 1)
                    {
                        tb_Palavra21.Text = tb_Chute1.Text;
                        tb_Palavra22.Text = tb_Chute2.Text;
                        tb_Palavra23.Text = tb_Chute3.Text;
                        tb_Palavra24.Text = tb_Chute4.Text;
                        tb_Palavra25.Text = tb_Chute5.Text;
                    }

                    char u = 'n'; // ver se ganhou ou nao
                    if (tb_Chute1.Text == pal[0])//valida acerto da palavra
                    {
                        if (tb_Chute2.Text == pal[1])
                        {
                            if (tb_Chute3.Text == pal[2])
                            {
                                if (tb_Chute4.Text == pal[3])
                                {
                                    if (tb_Chute5.Text == pal[4])
                                    {
                                        u = 's';
                                        Console.WriteLine("Aqui está o problema");
                                        MessageBox.Show("Parabéns! Você acertou a palavra");
                                    }
                                }
                            }
                        }
                    }
                    if (tb_Chute1.Text == pal[0])//valida acerto da primeira letra
                    {
                        if (GetVidas() == 5)//primeira letra certa
                        {
                            tb_Palavra1.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 4)
                        {
                            tb_Palavra6.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 3)
                        {
                            tb_Palavra11.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 2)
                        {
                            tb_Palavra16.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 1)
                        {
                            tb_Palavra21.BackColor = Color.Green;
                        }
                    }
                    else //primeira letra errada
                    {
                        if (tb_Chute1.Text == pal[1] || tb_Chute1.Text == pal[2] || tb_Chute1.Text == pal[3] || tb_Chute1.Text == pal[4])//primeira letra existe na palavra
                        {
                            if (GetVidas() == 5)
                            {
                                tb_Palavra1.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 4)
                            {
                                tb_Palavra6.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 3)
                            {
                                tb_Palavra11.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 2)
                            {
                                tb_Palavra16.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 1)
                            {
                                tb_Palavra21.BackColor = Color.Yellow;
                            }
                        }
                        else//primeira letra totalmente errada
                        {
                            if (GetVidas() == 5)
                            {
                                tb_Palavra1.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 4)
                            {
                                tb_Palavra6.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 3)
                            {
                                tb_Palavra11.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 2)
                            {
                                tb_Palavra16.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 1)
                            {
                                tb_Palavra21.BackColor = Color.Red;
                            }
                        }
                    }

                    if (tb_Chute2.Text == pal[1])//valida acerto da segunda letra
                    {
                        if (GetVidas() == 5)//segunda letra certa
                        {
                            tb_Palavra2.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 4)
                        {
                            tb_Palavra7.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 3)
                        {
                            tb_Palavra12.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 2)
                        {
                            tb_Palavra17.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 1)
                        {
                            tb_Palavra22.BackColor = Color.Green;
                        }
                    }
                    else //segunda letra errada
                    {
                        if (tb_Chute2.Text == pal[0] || tb_Chute2.Text == pal[2] || tb_Chute2.Text == pal[3] || tb_Chute2.Text == pal[4])//segunda letra existe na palavra
                        {
                            if (GetVidas() == 5)
                            {
                                tb_Palavra2.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 4)
                            {
                                tb_Palavra7.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 3)
                            {
                                tb_Palavra12.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 2)
                            {
                                tb_Palavra17.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 1)
                            {
                                tb_Palavra22.BackColor = Color.Yellow;
                            }
                        }
                        else//segunda letra totalmente errada
                        {
                            if (GetVidas() == 5)
                            {
                                tb_Palavra2.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 4)
                            {
                                tb_Palavra7.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 3)
                            {
                                tb_Palavra12.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 2)
                            {
                                tb_Palavra17.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 1)
                            {
                                tb_Palavra22.BackColor = Color.Red;
                            }
                        }
                    }

                    if (tb_Chute3.Text == pal[2])//valida acerto da terceira letra
                    {
                        if (GetVidas() == 5)//terceira letra certa
                        {
                            tb_Palavra3.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 4)
                        {
                            tb_Palavra8.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 3)
                        {
                            tb_Palavra13.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 2)
                        {
                            tb_Palavra18.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 1)
                        {
                            tb_Palavra23.BackColor = Color.Green;
                        }
                    }
                    else//terlceira letra errada
                    {
                        if (tb_Chute3.Text == pal[0] || tb_Chute3.Text == pal[1] || tb_Chute3.Text == pal[3] || tb_Chute3.Text == pal[4])//terceira letra existe na palavra
                        {
                            if (GetVidas() == 5)
                            {
                                tb_Palavra3.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 4)
                            {
                                tb_Palavra8.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 3)
                            {
                                tb_Palavra13.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 2)
                            {
                                tb_Palavra18.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 1)
                            {
                                tb_Palavra23.BackColor = Color.Yellow;
                            }
                        }
                        else//terceira letra totalmente errada
                        {
                            if (GetVidas() == 5)
                            {
                                tb_Palavra3.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 4)
                            {
                                tb_Palavra8.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 3)
                            {
                                tb_Palavra13.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 2)
                            {
                                tb_Palavra18.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 1)
                            {
                                tb_Palavra23.BackColor = Color.Red;
                            }
                        }
                    }

                    if (tb_Chute4.Text == pal[3])//valida acerto da quarta letra
                    {
                        if (GetVidas() == 5)//quarta letra certa
                        {
                            tb_Palavra4.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 4)
                        {
                            tb_Palavra9.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 3)
                        {
                            tb_Palavra14.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 2)
                        {
                            tb_Palavra19.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 1)
                        {
                            tb_Palavra24.BackColor = Color.Green;
                        }
                    }
                    else //quarta letra errada
                    {
                        if (tb_Chute4.Text == pal[0] || tb_Chute4.Text == pal[1] || tb_Chute4.Text == pal[2] || tb_Chute4.Text == pal[4])//quarta letra existe na palavra
                        {
                            if (GetVidas() == 5)
                            {
                                tb_Palavra4.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 4)
                            {
                                tb_Palavra9.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 3)
                            {
                                tb_Palavra14.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 2)
                            {
                                tb_Palavra19.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 1)
                            {
                                tb_Palavra24.BackColor = Color.Yellow;
                            }
                        }
                        else//quarta letra totalmente errada
                        {
                            if (GetVidas() == 5)
                            {
                                tb_Palavra4.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 4)
                            {
                                tb_Palavra9.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 3)
                            {
                                tb_Palavra14.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 2)
                            {
                                tb_Palavra19.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 1)
                            {
                                tb_Palavra24.BackColor = Color.Red;
                            }
                        }
                    }
                    if (tb_Chute5.Text == pal[4])//valida acerto da quinta letra
                    {
                        if (GetVidas() == 5)//quinta letra certa
                        {
                            tb_Palavra5.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 4)
                        {
                            tb_Palavra10.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 3)
                        {
                            tb_Palavra15.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 2)
                        {
                            tb_Palavra20.BackColor = Color.Green;
                        }
                        else if (GetVidas() == 1)
                        {
                            tb_Palavra25.BackColor = Color.Green;
                        }
                    }
                    else //quinta letra errada
                    {
                        if (tb_Chute5.Text == pal[0] || tb_Chute5.Text == pal[1] || tb_Chute5.Text == pal[2] || tb_Chute5.Text == pal[3])//quinta letra existe na palavra
                        {
                            if (GetVidas() == 5)
                            {
                                tb_Palavra5.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 4)
                            {
                                tb_Palavra10.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 3)
                            {
                                tb_Palavra15.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 2)
                            {
                                tb_Palavra20.BackColor = Color.Yellow;
                            }
                            else if (GetVidas() == 1)
                            {
                                tb_Palavra25.BackColor = Color.Yellow;
                            }
                        }
                        else//quinta letra totalmente errada
                        {
                            if (GetVidas() == 5)
                            {
                                tb_Palavra5.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 4)
                            {
                                tb_Palavra10.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 3)
                            {
                                tb_Palavra15.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 2)
                            {
                                tb_Palavra20.BackColor = Color.Red;
                            }
                            else if (GetVidas() == 1)
                            {
                                tb_Palavra25.BackColor = Color.Red;
                            }
                        }
                    }
                    if (u == 'n')//continua o programa se a palavra estiver incorreta
                    {
                        TiraVida();
                        lb_Vidas.Text = "Vidas: " + GetVidas().ToString();
                        LimpaTbChute();
                        tb_Chute1.Focus();
                        //lb_Titulo.Text = palavra; ver qual a palavra escolhida
                        Console.WriteLine(palavra);
                    }

                }
                else
                {
                    MessageBox.Show("Você não conseguiu acertar a palavra :(\n A palavra era: " + nPalavra);
                }
            }
            else { MessageBox.Show("Clique em Começar"); }
        }

        private void btn_Resetar_Click(object sender, EventArgs e)
        {
            ComecarJogo();
            SetPalavra(Palavra());
            ResetaVidas();
            lb_Titulo.Text = "Tente acertar a palavra";
            btn_Resetar.Text = "Trocar palavra";
            lb_Vidas.Text = "Vidas: " + GetVidas();
            LimpaTbChute();
            LimpaTbPalavra();
            tb_Chute1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
