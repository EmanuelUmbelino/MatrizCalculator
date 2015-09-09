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
            MA = new TextBox[int.Parse(M1X.Value.ToString()), int.Parse(M1Y.Value.ToString())];
            for (int i = 0; i < M1X.Value; i++)
            {
                for (int j = 0; j < M1Y.Value; j++)
                {
                    MA[i, j] = new TextBox();
                    MA[i, j].Location = new Point(M1X.Location.X + i * 40, 100 + j * 30);
                    MA[i, j].Width = 30;
                    Controls.Add(MA[i, j]);
                }
            }
        }
        void ReloadB()
        {
            MB = new TextBox[int.Parse(M2X.Value.ToString()), int.Parse(M2Y.Value.ToString())];
            for (int i = 0; i < M2X.Value; i++)
            {
                for (int j = 0; j < M2Y.Value; j++)
                {
                    MB[i, j] = new TextBox();
                    MB[i, j].Location = new Point(M2X.Location.X + i * 40, 100 + j * 30);
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
            MC = new TextBox[int.Parse(M3X.Text), int.Parse(M3Y.Text)];
            for (int i = 0; i < int.Parse(M3X.Text); i++)
            {
                for (int j = 0; j < int.Parse(M3Y.Text); j++)
                {
                    MC[i, j] = new TextBox();
                    MC[i, j].Location = new Point(M3X.Location.X + i * 40, 100 + j * 30);
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
                if (M1X.Value.Equals(M2X.Value) && M1Y.Value.Equals(M2Y.Value))
                {
                    M3X.Text = M1X.Value.ToString();
                    M3Y.Text = M1Y.Value.ToString();
                    ReloadC();
                    try
                    {
                        for (int i = 0; i < int.Parse(M3X.Text); i++)
                        {
                            for (int j = 0; j < int.Parse(M3Y.Text); j++)
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
        }
    }
}
