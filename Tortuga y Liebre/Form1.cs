using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortuga_y_Liebre
{
    public partial class Form1 : Form
    {
        private Tortuga tortuga;
        private Conejo conejo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            tortuga = new Tortuga();
            conejo = new Conejo();
            while (conejo.posicion < 80 && tortuga.posicion < 80)
            {
                tortuga.correr();
                conejo.correr();
                
                txtResult.Text += tortuga.ToString() + Environment.NewLine + conejo.ToString() + Environment.NewLine;
            }
            if (conejo.posicion >= 80 && tortuga.posicion >= 80)
                MessageBox.Show("Empate");
            else if (tortuga.posicion >= 80)
                MessageBox.Show("Gano la tortuga");
            else if (conejo.posicion >= 80)
                MessageBox.Show("Gano la liebre");
        }
    }
}
