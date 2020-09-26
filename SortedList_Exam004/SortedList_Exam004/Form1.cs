using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SortedList_Exam004
{
    public partial class Form1 : Form
    {

        SortedList Lists;

        public Form1()
        {
            InitializeComponent();
            Lists = new SortedList();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            
            Lists.Add( int.Parse(txtKeys.Text), txtValues.Text);
            ICollection Collection = Lists.Keys;
int i = 0;
            foreach (int key in Collection)
            {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = Lists[key].ToString();
                    i = i+1;
            }
        }
    }
}
