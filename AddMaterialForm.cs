using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GetDataFromDataBase
{
    public partial class AddMaterialForm : Form
    {
        List<Material> materials = new List<Material>();
        public AddMaterialForm()
        {
            InitializeComponent();
            this.FormClosing += AddMaterialForm_FormClosing;
            Material material = new Material("name", "number");
            AddMaterial();
            FillDataGrid();
        }

        private void AddMaterialForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;// отмена закрытия формы
            Hide();// сокрытие формыы
        }
        private void AddMaterial()
        {
            var xDoc = new XmlDocument();
            xDoc.Load("ListOfMaterials.xml");
        }
        private void FillDataGrid()
        {
            var dataSet = new DataSet();
            dataSet.ReadXml("ListOfMaterials.xml");
            materialGridView.DataSource = dataSet;
            materialGridView.DataMember = "materials";
        }
    }
}
