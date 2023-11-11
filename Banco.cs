using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela
{

    public partial class Banco : Form
    {
        Cliente cliente;
        public Banco()
        {
            InitializeComponent();
           this.cliente = new Cliente();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void simToolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void simToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            try
            {
            double valor = Convert.ToDouble(txtOperacao.Text);
            cliente.depositoSaldo(valor);
            txtSaldo.Text = cliente.saldo.ToString(".00");
            txtOperacao.Clear();
            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            

                
            
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOperacao_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btCreditar_Click(object sender, EventArgs e)
        {
            try 
            { 
            double valor = Convert.ToDouble(txtOperacao.Text);
            cliente.saqueSaldo(valor);
            txtSaldo.Text = cliente.saldo.ToString("0.00");
            txtOperacao.Clear();
            }
            catch (Exception exception)
            { 
            MessageBox.Show(exception.Message);
            }

            txtOperacao.Clear();
        }
    }
}
