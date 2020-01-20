using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataFromDataBase
{
    /// <summary>
    /// Класс содержащий имя и номер материала в базе К-3
    /// </summary>
    public class Material
    {
        public string Name { get; private set; }
        public string Number { get; }
        public Material(string name, string number)
        {
            SetName(name);
            Number = number;
        }
        private void SetName(string name)
        {
            string temp = name.Replace(' ', '•').ToLower();
            StringBuilder nameSB = new StringBuilder(temp);
            nameSB[0] = char.ToUpper(nameSB[0]);
            Name = nameSB.ToString();
        }
    }
}
