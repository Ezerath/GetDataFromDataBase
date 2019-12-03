using System;

namespace GetDataFromDataBase
{
    class Detail
    {
        string Name { get; set; }//имя детали
        string Length;//длина детали
        string Width;// ширина детали
        public string Material { get; set; }// материал детали
        // типы кромок по сторонам детали
        string EdgeB;
        string EdgeBcolor;
        string EdgeC;
        string EdgeCcolor;
        string EdgeD;
        string EdgeDcolor;
        string EdgeE;
        string EdgeEcolor;
        int Count;
        public Detail(string name, string length, string width, string material, string edgeB, string edgeC, string edgeD, string edgeE)
        {
            Name = name;
            Length = length;
            Width = width;
            Material = SetMaterial(material);
            if (edgeB != "0")
            {
                EdgeB = "128";
                EdgeBcolor = "1";
            }
            else
            {
                EdgeB = "0";
                EdgeBcolor = "0";
            }
            if (edgeC != "0")
            {
                EdgeC = "128";
                EdgeCcolor = "1";
            }
            else
            {
                EdgeC = "0";
                EdgeCcolor = "0";
            }
            if (edgeD != "0")
            {
                EdgeD = "128";
                EdgeDcolor = "1";
            }
            else
            {
                EdgeD = "0";
                EdgeDcolor = "0";
            }
            if (edgeE != "0")
            {
                EdgeE = "128";
                EdgeEcolor = "1";
            }
            else
            {
                EdgeE = "0";
                EdgeEcolor = "0";
            }
            Count = 1;
        }

        private string SetMaterial(string material)
        {
            switch (material)
            {
                case "281":
                    return "NoMaterial";
                case "314":
                    return "Хдф";
                case "492":
                    return "ДспБелое";
                case "1590":
                    return "Smart";
                case "1581":
                    return "Agt";
                default:
                    return "NoMaterial";
            }
        }

        public string Show()
        {
            // возврат строки в формате для cutting 
            // длина ширина кол-во имя материал вращение приоритет 
            // цвет кромки по сторонам тип кромки по сторонам
            return $"{Length} {Width} {Count} {Name} {Material} 1 2 " +
                $"{EdgeB} {EdgeC} {EdgeD} {EdgeE} {EdgeBcolor} {EdgeCcolor} {EdgeDcolor} {EdgeEcolor}";
        }
    }
}
