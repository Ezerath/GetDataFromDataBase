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
        string name;
        string number;
        public Material(string name, string number)
        {
            this.name = name;
            this.number = number;
        }
    }
}
