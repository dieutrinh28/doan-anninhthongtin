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

        static string Encipher(string plainText, string key)
        {
            string result = "";

            for (int i = 0; i < plainText.Length; i++)
            {
                int num = (plainText[i] - 97) + (key[i] - 97);
                result += (char)((num % 26) + 97);
            }

            return result;
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            if (txtbox_key.Text.Length != txtbox_input.Text.Length)
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

            }

            lbl_output.Text = Encipher(txtbox_input.Text, txtbox_key.Text);

        }
    }
}
