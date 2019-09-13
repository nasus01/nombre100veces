using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mostrar_el_nombre_100_en_datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int limite = 100;
            for(i=0; i < limite; i++)
            {
                dataGridView1.Rows.Add(i + 1, txtnombre.Text);
            }
        }
    }
}
