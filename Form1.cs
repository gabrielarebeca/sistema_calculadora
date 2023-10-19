    using System;
using System.Windows.Forms;

namespace WFACalculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

        }
        private void rdbSomar_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "+";
        }

        private void rdbSubtrair_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "-";
        }

        private void rdbDividir_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "/";
        }

        private void rdbMutiplicar_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "x";
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
           {
               e.Cancel = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rdbSomar.Checked)
            {
                MessageBox.Show("A soma é: " + (Convert.ToDouble(txtNum1.Text) + double.Parse(txtNum2.Text))
                    , "Resposta:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbSubtrair.Checked)
            {
                MessageBox.Show("A subtração é: " + (Convert.ToDouble(txtNum1.Text) - double.Parse(txtNum2.Text))
                    , "Resposta:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbDividir.Checked)
            {
                MessageBox.Show("A Divisão é: " + (Convert.ToDouble(txtNum1.Text) / double.Parse(txtNum2.Text))
                    , "Resposta:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbMutiplicar.Checked)
            {
                MessageBox.Show("O produto é: " + (Convert.ToDouble(txtNum1.Text) * double.Parse(txtNum2.Text))
                    , "Resposta:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            rdbDividir.Checked = false;
            rdbMutiplicar.Checked = false;
            rdbSomar.Checked = false;
            rdbSubtrair.Cheked = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblOper_Click(object sender, EventArgs e)
        {

        }
    }
}
