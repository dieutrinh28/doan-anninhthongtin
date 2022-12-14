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
    public partial class VigenereCipher : Form
    {
        public VigenereCipher()
        {
            InitializeComponent();
        }
     
        public static string Encipher(string plainText, string key)
        {
            string result = "";
            string inputText = plainText.ToLower();
            StringBuilder input = new StringBuilder(inputText);

            int idex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    input[i] = (char)(input[i] + key[idex] - 'a');
                    if (input[i] > 'z')
                    {
                        input[i] = (char)(input[i] - 'z' + 'a' - 1);
                    }
                }
                idex = idex + 1 == key.Length ? 0 : idex + 1;
            }
            result = input.ToString();
            return result;
        }
      
        public static string Decipher(string enText, string key)
        {
            string result = "";
            string inputText = enText.ToLower();
            StringBuilder input = new StringBuilder(inputText);

            int idex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    input[i] = input[i] >= key[idex] ?
                        (char)(input[i] - key[idex] + 'a') :
                        (char)('a' + ('z' - key[idex] + input[i] - 'a') + 1);
                }
                idex = idex + 1 == key.Length ? 0 : idex + 1;
            }
            result = input.ToString();
            return result;
        }


        /*private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            string inputText = txtInput.Text.ToLower();
            StringBuilder input = new StringBuilder(inputText);
            string key = txtKey.Text.ToLower();

            int idex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetter(input[i]))
                {
                    MessageBox.Show("Text không được chứa số hay ký tự đặc biệt", "Error");
                    txtInput.Text = "";
                    return;
                }
                if (char.IsLetter(input[i]))
                {
                    input[i] = (char)(input[i] + key[idex] - 'a');
                    if (input[i] > 'z')
                    {
                        input[i] = (char)(input[i] - 'z' + 'a' - 1);
                    }
                }
                idex = idex + 1 == key.Length ? 0 : idex + 1;
            }
            txtOutput.Text = input.ToString();
        }*/


        /*private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
            string inputText = txtInput.Text.ToLower();
            StringBuilder input = new StringBuilder(inputText);
            string key = txtKey.Text.ToLower();

            int idex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetter(input[i]))
                {
                    MessageBox.Show("Text không được chứa số hay ký tự đặc biệt", "Error");
                    txtInput.Text = "";
                    return;
                }
                if (char.IsLetter(input[i]))
                {
                    input[i] = input[i] >= key[idex] ?
                        (char)(input[i] - key[idex] + 'a') :
                        (char)('a' + ('z' - key[idex] + input[i] - 'a') + 1);
                }
                idex = idex + 1 == key.Length ? 0 : idex + 1;
            }
            txtOutput.Text = input.ToString();
        }*/

        private void btnEncrypt_Click(object sender, EventArgs e)
        {

            foreach (char ch in txtInput.Text)
            {
                if (!char.IsLetter(ch))
                {
                    MessageBox.Show("Text không được chứa số hay ký tự đặc biệt", "Error");
                    txtInput.Text = "";
                    return;
                }
            }
            txtOutput.Text = Encipher(txtInput.Text.ToLower(), txtKey.Text.ToLower());
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            foreach (char ch in txtInput.Text)
            {
                if (!char.IsLetter(ch))
                {
                    MessageBox.Show("Text không được chứa số hay ký tự đặc biệt", "Error");
                    txtInput.Text = "";
                    return;
                }
            }
            txtOutput.Text = Decipher(txtInput.Text.ToLower(), txtKey.Text.ToLower());
        }
    }
}
