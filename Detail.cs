using System;

namespace GetDataFromDataBase
{
    public class Detail : IComparable<Detail>
    {
        string Name { get; set; }//имя детали
        string Length;//длина детали
        string Width;// ширина детали
        public string Material { get; set; }// материал детали
        // типы кромок по сторонам детали
        string EdgeB = string.Empty;
        string EdgeC = string.Empty;
        string EdgeD = string.Empty;
        string EdgeE = string.Empty;
        string Thinkness = string.Empty;
        public int Count { get; private set; }
        public Detail(string name, string length, string width, string material, string edgeB, string edgeC, string edgeD, string edgeE)
        {
            SetName(name);
            Length = length;
            Width = width;
            Material = SetMaterialShort(material);
            SetEdges(edgeB, edgeC, edgeD, edgeE);
            Count = 1;
        }

        private void SetName(string name)
        {
            Name = name.Replace(' ', '•');
        }

        private void SetEdges(string edgeB, string edgeC, string edgeD, string edgeE)
        {
            if (edgeB != "0")
            {
                SetEdgeB(edgeB);
            }
            if (edgeC != "0")
            {
                SetEdgeC(edgeC);
            }
            if (edgeD != "0")
            {
                SetEdgeD(edgeD);
            }
            if (edgeE != "0")
            {
                SetEdgeE(edgeE);
            }
        }

        private void SetEdgeE(string edgeE)
        {
            switch (edgeE)
            {
                case "1582":
                    EdgeE = "2мм";
                    Width = (int.Parse(Width) - 2).ToString();
                    break;
                case "1588":
                    EdgeE = "1мм";
                    break;
                default:
                    EdgeE = "0,4мм";
                    break;
            }
        }

        private void SetEdgeD(string edgeD)
        {
            switch (edgeD)
            {
                case "1582":
                    EdgeD = "2мм";
                    Width = (int.Parse(Width) - 2).ToString();
                    break;
                case "1588":
                    EdgeD = "1мм";
                    break;
                default:
                    EdgeD = "0,4мм";
                    break;
            }
        }

        private void SetEdgeC(string edgeC)
        {
            switch (edgeC)
            {
                case "1582":
                    EdgeC = "2мм";
                    Length = (int.Parse(Length) - 2).ToString();
                    break;
                case "1588":
                    EdgeC = "1мм";
                    break;
                default:
                    EdgeC = "0,4мм";
                    break;
            }
        }

        private void SetEdgeB(string edgeB)
        {
            switch (edgeB)
            {
                case "1582":
                    EdgeB = "2мм";
                    Length = (int.Parse(Length) - 2).ToString();
                    break;
                case "1588":
                    EdgeB = "1мм";
                    break;
                default:
                    EdgeB = "0,4мм";
                    break;
            }
        }
        private string SetMaterialShort(string material)
        {
            switch (material)
            {
                case "281":
                    return "Русский" + '•' + "ламинат";
                case "314":
                    return "Хдф";
                case "492":
                    return "ДспБелое";
                case "1590":
                    return "Smart";
                case "1581":
                    return "Agt";
                case "1596":
                    return "Желтое";
                case "1597":
                    return "Зеленое";
                case "1598":
                    return "Оранжевое";
                case "1595":
                    return "Красное";
                default:
                    return "NoMaterial";
            }
        }
        private string SetMaterial(string material)
        {
            switch (material)
            {
                case "281":
                    Thinkness = "16";
                    return "ДСП 16";
                case "314":
                    Thinkness = "4";
                    return "ХДФ белое";
                case "492":
                    return "ДспБелое";
                case "1590":
                    return "Smart";
                case "1581":
                    return "Agt";
                case "1596":
                    return "Желтое";
                case "1597":
                    return "Зеленое";
                case "1598":
                    return "Оранжевое";
                case "1595":
                    return "Красное";
                default:
                    return "NoMaterial";
            }
        }
        public string ShowAstra()
        {
            return $"{Length}\t{Width}\t{Count}\t1\t{Thinkness}\t{Material}\t{Name}\t{EdgeD}\t{EdgeE}\t{EdgeC}\t{EdgeB}";
        }
        public string ShowCuttingShort()
        {
            return $"{Length} {Width} {Count} {Name} {Material}";
        }
        //public string Show()
        //{
        //    // возврат строки в формате для cutting 
        //    // (длина ширина кол-во имя материал вращение приоритет 
        //    // цвет кромки по сторонам тип кромки по сторонам) 
        //    //{ EdgeDcolor} {EdgeEcolor} {EdgeBcolor} {EdgeCcolor} {EdgeD} {EdgeE} {EdgeB} {EdgeC}
        //    // {EdgeCcolor} {EdgeBcolor} {EdgeDcolor} {EdgeEcolor} {EdgeC} {EdgeB} {EdgeD} {EdgeE}
        //    return $"{Length} {Width} {Count} {Name} {Material} 1 2 " +
        //        $" {EdgeDcolor} {EdgeEcolor} {EdgeBcolor} {EdgeCcolor} {EdgeD} {EdgeE} {EdgeB} {EdgeC}";
        //}
        private bool Equals(Detail obj)
        {
            return Name == obj.Name && Length == obj.Length && Width == obj.Width && Material == obj.Material &&
                EdgeB == obj.EdgeB && EdgeC == obj.EdgeC && EdgeD == obj.EdgeD && EdgeE == obj.EdgeE;
        }
        //&&
        //        EdgeBcolor == obj.EdgeBcolor && EdgeCcolor == obj.EdgeCcolor &&
        //        EdgeDcolor == obj.EdgeDcolor && EdgeEcolor == obj.EdgeEcolor;
        //}
        public override bool Equals(object obj)
        {
            if (!(obj is Detail))
                return false;
            return Equals((Detail)obj);
        }
        public void AddCount()
        {
            Count++;
        }

        public int CompareTo(Detail det)
        {
            return Material.CompareTo(det.Material);
        }
    }
}
