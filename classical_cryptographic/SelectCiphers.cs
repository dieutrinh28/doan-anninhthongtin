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
    public partial class SelectCiphers : Form
    {
        public SelectCiphers()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int index = cobSelectCipher.SelectedIndex;
            switch (index)
            {
                case 0:
                    this.Hide();
                    MonoalphabeticSubstitutionCipher form0 = new MonoalphabeticSubstitutionCipher();
                    form0.Show();
                    break;
                case 1:
                    this.Hide();
                    VigenereCipher form1 = new VigenereCipher();
                    form1.Show();
                    break;
                case 2:
                    this.Hide();
                    PlayFairCipher form2 = new PlayFairCipher();
                    form2.Show();
                    break;
                case 3:
                    this.Hide();
                    One_TimePad form3 = new One_TimePad();
                    form3.Show();
                    break;
                case 4:
                    this.Hide();
                    RailFenceCipher form4 = new RailFenceCipher();
                    form4.Show();
                    break;
            }
        }
    }
}
