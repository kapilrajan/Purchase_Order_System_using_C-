using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purchase_Order_System_using_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        string name;
        int p_rice;
     


        private void add_Click(object sender, EventArgs e)
        {
            if (checkwash.Checked)
            {
                name = "Car Wash";
                p_rice = 300;
                this.dataGridView1.Rows.Add(name, p_rice);

            }
            if (checkgeneral.Checked)
            {
                name = "General Service";
                p_rice = 3000;
                this.dataGridView1.Rows.Add(name, p_rice);

            }
            if (checkoil.Checked)
            {
                name = "Oil Service";
                p_rice = 1500;
                this.dataGridView1.Rows.Add(name, p_rice);

            }
            if (checkpaint.Checked)
            {
                name = "Painting";
                p_rice = 5000;
                this.dataGridView1.Rows.Add(name, p_rice);

            }
            if (checktyre.Checked)
            {
                name = "Tyre Change";
                p_rice = 6000;
                this.dataGridView1.Rows.Add(name, p_rice);

            }
            if (checkwheel.Checked)
            {
                name = "Wheel Alignment";
                p_rice = 800;
                this.dataGridView1.Rows.Add(name, p_rice);

            }

            int sum = 0;
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {

                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[1].Value);    
            }

            texttotal.Text = sum.ToString(); 

        }

        private void texttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);


                int sum = 0;
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {

                    sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[1].Value);
                }

                texttotal.Text = sum.ToString();
            }

        }
    }
}
