using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  BusinessLayer.Employe.Get();
            textBox1.Text =  ServiceLayer.Service.GetPost();

            dataGridView2.DataSource = BusinessLayer.Employe.GetByPage(5);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            
            dataGridView2.DataSource = BusinessLayer.Employe.GetByPage(5);
        }
    }
}
