using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GetDataFromDataBase
{
    public partial class MainForm : Form
    {
        List<Detail> details;
        public MainForm()
        {
            InitializeComponent();
            details = new List<Detail>();
            testButton.Click += TestButton_Click;
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            SetConnection();
            SumByCount();
            foreach (var item in details)
            {
                resultTextBox.Text += item.Show() + "\n";
            }
        }

        private void SumByCount()
        {
            for (int i = 0; i < details.Count; i++)
            {
                var temp = details[i];
                for (int j = i + 1; j < details.Count; j++)
                {
                    if (temp.Equals(details[j]))
                    {
                        details[i].AddCount();
                        details.RemoveAt(j);
                        j--;
                    }
                }
            }
        }

        private void SetConnection()
        {
            //указываем путь к базе данных
            string connectionAdress = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files (x86)\GeoS\K3-Мебель-ПКМ\Bin\BOutTbl.mdb";
            // создаем подключение к базе данных
            OleDbConnection connection = new OleDbConnection(connectionAdress);

            //подключаемся к базе данных
            ConnectToDataBase(connection);
        }

        private void ConnectToDataBase(OleDbConnection connection)
        {
            using (connection)
            {
                //открываем подключение
                connection.Open();
                // указываем к каким ячейкам надо обратиться
                string query = "SELECT NAME, XUNIT, YUNIT, PRICEID, KNBID, KNCID, KNDID, KNEID FROM BOutTbl WHERE GROUPID = 17 ";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();
                // считываем и заполняем список деталей
                ReadDataBase(reader);
                connection.Close();
                command.Dispose();
            }
        }

        private void ReadDataBase(OleDbDataReader reader)
        {
            while (reader.Read())
            {
                string name = reader[0].ToString();
                string length = reader[1].ToString();
                string width = reader[2].ToString();
                string material = reader[3].ToString();
                string edgeB = reader[4].ToString();
                string edgeC = reader[5].ToString();
                string edgeD = reader[6].ToString();
                string edgeE = reader[7].ToString();
                details.Add(new Detail(name, length, width, material, edgeB, edgeC, edgeD, edgeE));
            }
        }
    }
}
