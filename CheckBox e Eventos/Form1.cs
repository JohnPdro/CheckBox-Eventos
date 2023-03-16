using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_e_Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            string txt = "";
            if (chkMaca.Checked)
            {
                txt += chkMaca.Text + ", ";
            }
            if (chkUva.Checked)
            {
                txt += chkUva.Text + ", ";
            }
            if (chkLaranja.Checked)
            {
                txt += chkLaranja.Text + ", ";
            }
            if (chkAbacaxi.Checked)
            {
                txt += chkAbacaxi.Text + ", ";
            }
            if (chkMelancia.Checked)
            {
                txt += chkMelancia + ", ";
            }
            MessageBox.Show("A fruta escolhida foi: " + txt, "A fruta escolhida foi...");
        }
    }
}
