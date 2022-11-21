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
    public partial class One_TimePad : Form
    {
        public One_TimePad()
        {
            InitializeComponent();
        }
        static string RandomKey(int textLength)
        {
            string UpperCase = "QWERTYUIOPASDFGHJKLZXCVBNM";
            /*string LowerCase = "qwertyuiopasdfghjklzxcvbnm";
            string Digits = "1234567890";*/
            /*string allCharacters = UpperCase + LowerCase + Digits*/;
            string allCharacters = UpperCase;
            Random r = new Random();
            String key = "";
            for (int i = 0; i < textLength; i++)
            {
                double rand = r.NextDouble();
                if (i == 0)
                {
                    key += UpperCase.ToCharArray()[(int)Math.Floor(rand * UpperCase.Length)];
                }
                else
                {
                    key += allCharacters.ToCharArray()[(int)Math.Floor(rand * allCharacters.Length)];
                }
            }
            return key;
        }

        static string Encipher(string plainText, string key)
        {
            string result = "";
            int[] num = new int[plainText.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                num[i] = (plainText[i] - 'A') + (key[i] - 'A');

            }
            for (int i = 0; i < plainText.Length; i++)
            {
                if (num[i] > 25)
                {
                    num[i] = num[i] - 26;
                }    
            }
            for (int i = 0; i < plainText.Length; i++)
            {
                int x = num[i] + 'A';
                result += (char)x;
            }
            
            return result;
        }

        static string Decipher(string enText, string key)
        {
            string result = "";
            int[] num = new int[enText.Length];

            for (int i = 0; i < enText.Length; i++)
            {
                num[i] = (enText[i] - 'A') - (key[i] - 'A');

            }
            for (int i = 0; i < enText.Length; i++)
            {
                if (num[i] < 0)
                {
                    num[i] = num[i] + 26;
                }
            }
            for (int i = 0; i < enText.Length; i++)
            {
                int x = num[i] + 'A';
                result += (char)x;
            }

            return result;
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            /*if (txtbox_key.Text.Length != txtbox_input.Text.Length)
            {
                MessageBox.Show("Key has to be the same length as plain text");
                txtbox_key.Text = "";
                return;
            }*/


            /*foreach (char ch in txtbox_input.Text)
            {
                if (!char.IsLetter(ch))
                {
                    MessageBox.Show("Plain text cannot contain numbers or special characters", "Error");
                    txtbox_input.Text = "";
                    return;
                }
            }

            foreach (char ch in txtbox_key.Text)
            {
                if (!char.IsLetter(ch))
                {
                    MessageBox.Show("Key cannot contain numbers or special characters", "Error");
                    txtbox_key.Text = "";
                    return;
                }

            }*/
            int textLength = txtbox_input.TextLength;
            txtbox_key.Text = RandomKey(textLength);
            lbl_output.Text = Encipher(txtbox_input.Text.ToUpper(), txtbox_key.Text.ToUpper());

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            /*if (txtbox_key.Text.Length != txtbox_input.Text.Length)
            {
                MessageBox.Show("Key has to be the same length as plain text");
                txtbox_key.Text = "";
                return;
            }

            foreach (char ch in txtbox_input.Text)
            {
                if (!char.IsLetter(ch))
                {
                    MessageBox.Show("Plain text cannot contain numbers or special characters", "Error");
                    txtbox_input.Text = "";
                    return;
                }
            }

            foreach (char ch in txtbox_key.Text)
            {
                if (!char.IsLetter(ch))
                {
                    MessageBox.Show("Key cannot contain numbers or special characters", "Error");
                    txtbox_key.Text = "";
                    return;
                }

            }*/

            /* nếu muốn check decrytpt thì comment 2 dòng này */
            int textLength = txtbox_input.TextLength;
            txtbox_key.Text = RandomKey(textLength);


            lbl_output.Text = Decipher(txtbox_input.Text.ToUpper(), txtbox_key.Text.ToUpper());
        }
    }
}
