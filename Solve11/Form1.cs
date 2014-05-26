using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string str = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "txt files (*.txt)|*.txt";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofd.OpenFile()) != null)
                    {
                        StreamReader reader = new StreamReader(myStream);
                        str = reader.ReadToEnd();
                        inputBox1.Text = str;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)   
        {
            string[,] array2D = new string[20,20];
            string[] array = str.Split('\n');
            int searchDigit = 0;
            for (int i = 0; i < array.Length; i++)
            {
               string[] array2 = array[i].Split(' ');
               for (int j = 0; j < array2.Length; j++)
               {
                   array2D[i, j] = array2[j];
               }
            }

            int[,] digits = new int[20, 20];

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    digits[i, j] = Convert.ToInt32(array2D[i, j]);                        
                }
            }

          searchDigit = SearchGreatest(digits);
          outputBox2.Text = searchDigit.ToString();

        }

        private int SearchGreatest(int[,] digits)
        {
            int max = 0;
            int row = 0;
            int column = 0;
            int searchdigitI = 0;
            int searchdigit = 0;

           // max of right, down, diagonal

            for (int i = 0; i < 20;i++)
            {
                for(int j=0; j<20;j++)
                {
                    try
                    {
                        int searchDigitLeftRight = digits[i, j] * digits[i, j + 1] * digits[i, j + 2] * digits[i, j + 3];
                        int searchDigitUpDown = digits[i, j] * digits[i + 1, j] * digits[i + 2, j] * digits[i + 3, j];
                        int searchDigitDiagonal = digits[i, j] * digits[i + 1, j + 1] * digits[i + 2, j + 2] * digits[i + 3, j + 3];
                        if (searchDigitLeftRight > searchDigitUpDown)
                        {
                            if (searchDigitLeftRight > searchDigitDiagonal)
                            {
                                max = searchDigitLeftRight;
                            }
                            else
                            {
                                max = searchDigitDiagonal;
                            }
                        }
                        else
                        {
                            if (searchDigitUpDown > searchDigitDiagonal)
                            {
                                max = searchDigitUpDown;
                            }
                            else
                            {
                                max = searchDigitDiagonal;
                            }
                        }
                    }                      
                    catch
                    {

                    }
                    if (searchdigit < max)
                    {
                        searchdigit = max;
                        row = i;
                        column = j;

                    }
                }
            }

           // max of inverse diagonal 
  
            for (int i = 0; i < 19; i++)
            {
                for (int j = 19; j > -1; j--)
                {
                    try
                    {
                        int searchDigitInverseDiagonal = digits[i, j] * digits[i + 1, j - 1] * digits[i + 2, j - 2] * digits[i + 3, j - 3];
                        if (searchDigitInverseDiagonal > searchdigitI) { searchdigitI = searchDigitInverseDiagonal; }
                    }
                    catch
                    {

                    }
                }
            }

             return searchdigit > searchdigitI ? searchdigit : searchdigitI;
        }
  
    }
}
