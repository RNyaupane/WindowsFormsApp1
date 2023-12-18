using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            DataSet ds = PrepareData();

            dataGridViewData.DataSource = ds;
            dataGridViewData.DataMember = "Student";
            dataGridViewData.Refresh();
        }

        private static DataSet PrepareData()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("Student");
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Email");
            for (int i = 0; i < 20; i++)
            {
                DataRow dr = dt.NewRow();
                dr["Id"] = i + 1;
                dr["Name"] = $"Hello{i + 1}";
                dr["Email"] = $"hello{i + 1}@gmail.com";
                dt.Rows.Add(dr);
            }
            ds.Tables.Add(dt);

            return ds;
        }

        private void buttonAdoNet_Click(object sender, EventArgs e)
        {
            DataSet ds = PrepareDataUsingAdoNet();

            dataGridViewData.DataSource = ds;
            dataGridViewData.DataMember = "Student";
            dataGridViewData.Refresh();
        }

        private DataSet PrepareDataUsingAdoNet()
        {
            SqlConnection conn = new SqlConnection("");
        }
    }
}
