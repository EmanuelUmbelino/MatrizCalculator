using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrizCalculator
{
    public partial class Form1 : Form
    {
        TextBox[,] MA = new TextBox[1, 1];
        TextBox[,] MB = new TextBox[1, 1];
        TextBox[,] MC = new TextBox[1, 1];
        public Form1()
        {
            InitializeComponent(); 
            ReloadA();
            ReloadB();
           
        }
        void ReloadA()
        {
            MA = new TextBox[int.Parse(M1C.Value.ToString()),int.Parse(M1L.Value.ToString())];
            for (int i = 0; i < M1L.Value; i++)
            {
                for (int j = 0; j < M1C.Value; j++)
                {
                    MA[i, j] = new TextBox();
                    MA[i, j].Location = new Point(M1L.Location.X + i * 40, 100 + j * 30);
                    MA[i, j].Width = 30;
                    Controls.Add(MA[i, j]);
                }
            }
        }
        void ReloadB()
        {
            MB = new TextBox[int.Parse(M2C.Value.ToString()), int.Parse(M2L.Value.ToString())];
            for (int i = 0; i < M2L.Value; i++)
            {
                for (int j = 0; j < M2C.Value; j++)
                {
                    MB[i, j] = new TextBox();
                    MB[i, j].Location = new Point(M2L.Location.X + i * 40, 100 + j * 30);
                    MB[i, j].Width = 30;
                    Controls.Add(MB[i, j]);
                }
            }
        }
        void ReloadC()
        {
            foreach (TextBox text in MC)
            {
                Controls.Remove(text);
            }
            MC = new TextBox[int.Parse(M3L.Text), int.Parse(M3C.Text)];
            for (int i = 0; i < int.Parse(M3L.Text); i++)
            {
                for (int j = 0; j < int.Parse(M3C.Text); j++)
                {
                    MC[i, j] = new TextBox();
                    MC[i, j].Location = new Point(M3L.Location.X + i * 40, 100 + j * 30);
                    MC[i, j].Width = 30;
                    Controls.Add(MC[i, j]);
                }
            }
        }
        private void ChangeLengthB(object sender, EventArgs e)
        {
            foreach (TextBox text in MB)
            {
                Controls.Remove(text);
            }
            ReloadB();

        }

        private void ChangeLengthA(object sender, EventArgs e)
        {
            foreach (TextBox text in MA)
            {
                Controls.Remove(text);
            }
            ReloadA();

        }

        private void ChangeOperation(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            Operation.Text = clicked.Text;
        }

        private void Solution(object sender, EventArgs e)
        {
            if (Operation.Text.Equals("+") || Operation.Text.Equals("-"))
            {
                if (M1L.Value.Equals(M2L.Value) && M1C.Value.Equals(M2C.Value))
                {
                    M3L.Text = M1L.Value.ToString();
                    M3C.Text = M1C.Value.ToString();
                    ReloadC();
                    try
                    {
                        for (int i = 0; i < int.Parse(M3L.Text); i++)
                        {
                            for (int j = 0; j < int.Parse(M3C.Text); j++)
                            {
                                if (Operation.Text.Equals("+"))
                                    MC[i, j].Text = (int.Parse(MA[i, j].Text) + int.Parse(MB[i, j].Text)).ToString();
                                else
                                    MC[i, j].Text = (int.Parse(MA[i, j].Text) - int.Parse(MB[i, j].Text)).ToString();
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Não deixe caixas vazias e insira somente números.");
                    }
                }
                else
                    MessageBox.Show("Necessário que as duas matrizes sejam de mesmo tamanho para ocorrer essa operação.");
            }
            else if (Operation.Text.Equals("X"))
            {
                if (M1C.Value.Equals(M2L.Value))
                {
                    M3L.Text = M1L.Value.ToString();
                    M3C.Text = M2C.Value.ToString();
                    ReloadC();
                    try
                    {
                        int[,] C = new int[int.Parse(M1L.Value.ToString()), int.Parse(M2C.Value.ToString())];
                        for (int i = 0; i < M1L.Value; i++)
                        {
                            for (int j = 0; j < M2C.Value; j++)
                            {
                                for(int k = 0; k < M2L.Value; k++)
                                {

                                    MessageBox.Show("1");
                                    C[i, j] = int.Parse(MA[i, k].Text) * int.Parse(MB[k, j].Text);
                                    MC[i, j].Text = C[i, j].ToString();
                                }
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Não deixe caixas vazias e insira somente números.");
                    }

                }
                else
                    MessageBox.Show("Número de colunas da Matriz A deve ser igual ao número de linhas da Matriz B");
            }
        }
    }
}
