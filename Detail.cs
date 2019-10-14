using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataFromDataBase
{
    class Detail
    {
        string Name;//имя детали
        string Length;//длина детали
        string Width;// ширина детали
        string Material;// материал детали
        // типы кромок по сторонам детали
        string EdgeB;
        string EdgeC;
        string EdgeD;
        string EdgeE;
        public Detail(string name, string length, string width, string material, string edgeB,string edgeC, string edgeD, string edgeE)
        {
            Name = name;
            Length = length;
            Width = width;
            Material = material;
            EdgeB = edgeB;
            EdgeC = edgeC;
            EdgeD = edgeD;
            EdgeE = edgeE;
        }
    }
}
