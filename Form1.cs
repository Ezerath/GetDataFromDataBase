using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GetDataFromDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
        private void GetDataFromDataGrid()
        {
            List<Detail> details = new List<Detail>();
            for (int i = 0; i < dataGrid.RowCount - 1; i++)
            {
                string temp = string.Empty;
                try
                {
                    temp = dataGrid.Rows[i].Cells[7].Value.ToString();
                }
                catch
                {
                    //break;
                    MessageBox.Show("Error");
                }
                if (temp == "17")
                {
                    string name = dataGrid.Rows[i].Cells[0].Value.ToString();
                    string length = dataGrid.Rows[i].Cells[2].Value.ToString();
                    string width = dataGrid.Rows[i].Cells[3].Value.ToString();
                    string material = "";
                    string edgeB = dataGrid.Rows[i].Cells[4].Value.ToString();
                    string edgeC = dataGrid.Rows[i].Cells[5].Value.ToString();
                    string edgeD = dataGrid.Rows[i].Cells[6].Value.ToString();
                    string edgeE = dataGrid.Rows[i].Cells[7].Value.ToString();
                    details.Add(new Detail(name, length, width, material, edgeB, edgeC, edgeD, edgeE));
                }
            }
            MessageBox.Show("Done");
        }
    }
}
