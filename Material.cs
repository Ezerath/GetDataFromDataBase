using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GetDataFromDataBase
{
    /// <summary>
    /// Класс содержащий имя и номер материала в базе К-3
    /// </summary>
    public class Material
    {
        Dictionary<int, string> materialsList;
        public string NameCut2 { get; private set; }
        public string NameCut3 { get; private set; }
        public string Number { get; }
        public Material(string name, string number)
        {
            LoadMaterialsList();
            SetName(name);
            NameCut3 = "0";
            foreach (var item in materialsList)
            {
                if (item.Value == name)
                {
                    NameCut3 = item.Key.ToString();
                }
            }
            Number = number;
        }

        private void LoadMaterialsList()
        {
            materialsList = new Dictionary<int, string>();
            string path = "MaterialsList.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    var temp = line.Split(new char[] { '\t' });
                    string name = temp[0];
                    int id = int.Parse(temp[1]);
                    AddMaterial(id, name);
                }
            }
        }

        private void SetName(string name)
        {
            string temp = name.Replace(' ', '•').ToLower();
            StringBuilder nameSB = new StringBuilder(temp);
            nameSB[0] = char.ToUpper(nameSB[0]);
            NameCut2 = nameSB.ToString();
        }
        public void AddMaterial(int id, string name)
        {
            materialsList.Add(id, name);
        }
    }
}
