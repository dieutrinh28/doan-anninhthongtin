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
    public partial class SelectOptions : Form
    {
        public SelectOptions()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int index = cobSelectOptions.SelectedIndex;
            switch (index)
            {
                case 0:
                    this.Hide();
                    SelectCiphers form0 = new SelectCiphers();
                    form0.Show();
                    break;
                case 1:
                    this.Hide();
                    PracticalApplication form1 = new PracticalApplication();
                    form1.Show();
                    break;
            }
        }
    }
}
