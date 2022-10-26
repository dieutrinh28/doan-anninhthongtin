using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classical_cryptographic
{
    public partial class PlayFairCipher : Form
    {
       
        public PlayFairCipher()
        {
            InitializeComponent();
            btnEncrypt.Click += BtnEncrypt_Click;
            btnDecrypt.Click += BtnDecrypt_Click;
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            if(lbOutputEn.Text == "")
            {
                MessageBox.Show("Please ! Encrypt first");
            }
            else
            {
                List<string> splittedText = Split(lbOutputEn.Text);
                char[,] matrix = GenerateMatrix(txbK.Text);
                lbOutputDe.Text = Decipher(splittedText, matrix);
            }
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            foreach (char ch in txbM.Text)
            {
                if (!char.IsLetter(ch))
                {
                    MessageBox.Show("Plain text cannot contain numbers, spaces, or special characters");
                    txbM.Text = "";
                    return;
                }
            }

            foreach (char ch in txbK.Text)
            {
                if (!char.IsLetter(ch))
                {
                    MessageBox.Show("Key cannot contain numbers, spaces, or special characters");
                    txbK.Text = "";
                    return;
                }
            }

            List<string> splittedText = Split(txbM.Text);
            char[,] matrix = GenerateMatrix(txbK.Text);

            lbOutputEn.Text = Encipher(splittedText, matrix);
        }

        static string Encipher(List<string> splittedText, char[,] matrix)
        {
            string result = "";

            foreach (string pair in splittedText)
            {
                int row1 = 0;
                int col1 = 0;
                int row2 = 0;
                int col2 = 0;

                char l1 = char.ToLower(pair[0]);
                char l2 = char.ToLower(pair[1]);

                GetPosition(matrix, l1, ref row1, ref col1);
                GetPosition(matrix, l2, ref row2, ref col2);

                if (row1 == row2)
                {
                    if (col1 == 4)
                    {
                        result += matrix[row1, 0];
                        result += matrix[row1, col2 + 1];
                    }
                    else if (col2 == 4)
                    {
                        result += matrix[row1, col1 + 1];
                        result += matrix[row1, 0];
                    }
                    else
                    {
                        result += matrix[row1, col1 + 1];
                        result += matrix[row1, col2 + 1];
                    }
                }
                else if (col1 == col2)
                {
                    if (row1 == 4)
                    {
                        result += matrix[0, col1];
                        result += matrix[row2 + 1, col1];
                    }
                    else if (row2 == 4)
                    {
                        result += matrix[row1 + 1, col1];
                        result += matrix[0, col1];
                    }
                    else
                    {
                        result += matrix[row1 + 1, col1];
                        result += matrix[row2 + 1, col1];
                    }
                }
                else
                {
                    result += matrix[row1, col2];
                    result += matrix[row2, col1];
                }
            }

            return result;
        }
        static string Decipher(List<string> splittedText, char[,] matrix)
        {
            string result = "";

            foreach (string pair in splittedText)
            {
                int row1 = 0;
                int col1 = 0;
                int row2 = 0;
                int col2 = 0;

                char l1 = char.ToLower(pair[0]);
                char l2 = char.ToLower(pair[1]);

                GetPosition(matrix, l1, ref row1, ref col1);
                GetPosition(matrix, l2, ref row2, ref col2);

                if (row1 == row2)
                {
                    if (col1 == 0)
                    {
                        result += matrix[row1, 4];
                        result += matrix[row1, col2 - 1];
                    }
                    else if (col2 == 0)
                    {
                        result += matrix[row1, col1 - 1];
                        result += matrix[row1, 4];
                    }
                    else
                    {
                        result += matrix[row1, col1 - 1];
                        result += matrix[row1, col2 - 1];
                    }
                }
                else if (col1 == col2)
                {
                    if (row1 == 0)
                    {
                        result += matrix[4, col1];
                        result += matrix[row2 - 1, col1];
                    }
                    else if (row2 == 0)
                    {
                        result += matrix[row1 - 1, col1];
                        result += matrix[4, col1];
                    }
                    else
                    {
                        result += matrix[row1 - 1, col1];
                        result += matrix[row2 - 1, col1];
                    }
                }
                else
                {
                    result += matrix[row1, col2];
                    result += matrix[row2, col1];
                }
            }
            List<string> splitresult = new List<string>();

            int index = 0;
            while (index < result.Length)
            {
                splitresult.Add(result.Substring(index, 2));
                index += 2;
            }
            for (int i = 0; i < splitresult.Count; i++)
            {
                if(i == splitresult.Count - 1)
                {
                    if (splitresult[i].IndexOf('x') != -1)
                    {
                        
                        splitresult[i] = splitresult[i].Remove(1);
                        
                    }
                }
                if (splitresult[i].IndexOf('x') != -1)
                {
                    if (splitresult[i][0] == splitresult[i + 1][0])
                    {
                        splitresult[i] = splitresult[i].Remove(1);
                    }
                }
            }
            string result2 = "";
            foreach(string s in splitresult)
            {
                result2 += s;
            }
            return result2;
        }
        private static char[,] GenerateMatrix(string key)
        {
            string finalkey = key.ToLower();
            char[,] matrix = new char[5, 5];

            string duplicates = "";
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            int row = 0;
            int col = 0;

            foreach (char ch in finalkey)
            {
                if (col < 5)
                {
                    if (duplicates.IndexOf(ch) == -1)
                    {
                        if (ch == 'i')
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            duplicates += 'j';
                            col++;
                        }
                        else if (ch == 'j')
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            duplicates += 'i';
                            col++;
                        }
                        else
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            col++;
                        }
                    }
                }
                else
                {
                    row++;
                    col = 0;
                    if (duplicates.IndexOf(ch) == -1)
                    {
                        if (ch == 'i')
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            duplicates += 'j';
                            col++;
                        }
                        else if (ch == 'j')
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            duplicates += 'i';
                            col++;
                        }
                        else
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            col++;
                        }
                    }
                }
            }

            foreach (char ch in alphabet)
            {
                if (col < 5)
                {
                    if (duplicates.IndexOf(ch) == -1)
                    {
                        if (ch == 'i')
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            duplicates += 'j';
                            col++;
                        }
                        else if (ch == 'j')
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            duplicates += 'i';
                            col++;
                        }
                        else
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            col++;
                        }
                    }
                }
                else
                {
                    row++;
                    col = 0;
                    if (duplicates.IndexOf(ch) == -1)
                    {
                        if (ch == 'i')
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            duplicates += 'j';
                            col++;
                        }
                        else if (ch == 'j')
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            duplicates += 'i';
                            col++;
                        }
                        else
                        {
                            matrix[row, col] = ch;
                            duplicates += ch;
                            col++;
                        }
                    }
                }
            }

            return matrix;
        }

        private static List<string> Split(string plainText)
        {
            List<string> result = new List<string>();

            int index = 0;
            while (index < plainText.Length)
            {
                if (index == plainText.Length - 1 || plainText[index] == plainText[index + 1])
                {
                    result.Add(plainText[index] + "x");
                    index++;
                }
                else
                {
                    result.Add(plainText.Substring(index, 2));
                    index += 2;
                }
            }

            return result;
        }

        private static void GetPosition(char[,] matrix, char ch, ref int row, ref int col)
        {
            if (ch == 'j' || ch == 'i')
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (matrix[i, j] == 'j' || matrix[i, j] == 'i')
                        {
                            row = i;
                            col = j;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (matrix[i, j] == ch)
                        {
                            row = i;
                            col = j;
                        }
                    }
                }
            }
        }
    }
}
