using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_layer;
using System.Windows.Forms;

namespace three_tier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facade fc = Facade.get_controller();
            MessageBox.show(fc.get_Data_into_Facade(textBox1.Text, textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Facade fc = Facade.get_controller();
            DataSet ds = fc.retrive_Pass(textBox3.Text);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
