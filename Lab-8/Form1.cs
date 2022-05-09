using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 4; 
            dataGridView1.ColumnCount = 3; 
            int[,] a = new int[4, 3]; 
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 4; i++)
                for (j = 0; j < 3; j++)
                    a[i, j] = rand.Next(-100, 100);
            for (i = 0; i < 4; i++)
                for (j = 0; j < 3; j++)
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);

            int m = int.MaxValue;
            for (i = 0; i < 4; i++)
            {
                m = a[i, 0];
                for (j = 1; j < 3; j++)
                    if (a[i, j] < m) m = a[i, j];
                textBox1.Text += m.ToString() + " ";
            }

        }
    }
}
