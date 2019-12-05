namespace GetDataFromDataBase
{
    public class Detail
    {
        string Name { get; set; }//имя детали
        string Length;//длина детали
        string Width;// ширина детали
        public string Material { get; set; }// материал детали
        // типы кромок по сторонам детали
        string EdgeB = "0";
        string EdgeBcolor = "0";
        string EdgeC = "0";
        string EdgeCcolor = "0";
        string EdgeD = "0";
        string EdgeDcolor = "0";
        string EdgeE = "0";
        string EdgeEcolor = "0";
        public int Count { get; private set; }
        public Detail(string name, string length, string width, string material, string edgeB, string edgeC, string edgeD, string edgeE)
        {
            Name = name;
            Length = length;
            Width = width;
            Material = SetMaterial(material);
            SetEdges(edgeB, edgeC, edgeD, edgeE);
            Count = 1;
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
            EdgeE = "1";
            switch (edgeE)
            {
                case "1582":
                    EdgeEcolor = "8388736";
                    Width = (int.Parse(Width) - 2).ToString();
                    break;
                case "1588":
                    EdgeEcolor = "0";
                    break;
                default:
                    EdgeEcolor = "128";
                    break;
            }
        }

        private void SetEdgeD(string edgeD)
        {
            EdgeD = "1";
            switch (edgeD)
            {
                case "1582":
                    EdgeDcolor = "8388736";
                    Width = (int.Parse(Width) - 2).ToString();
                    break;
                case "1588":
                    EdgeDcolor = "0";
                    break;
                default:
                    EdgeDcolor = "128";
                    break;
            }
        }

        private void SetEdgeC(string edgeC)
        {
            EdgeC = "1";
            switch (edgeC)
            {
                case "1582":
                    EdgeCcolor = "8388736";
                    Length = (int.Parse(Length) - 2).ToString();
                    break;
                case "1588":
                    EdgeCcolor = "0";
                    break;
                default:
                    EdgeCcolor = "128";
                    break;
            }
        }

        private void SetEdgeB(string edgeB)
        {
            EdgeB = "1";
            switch (edgeB)
            {
                case "1582":
                    EdgeBcolor = "8388736";
                    Length = (int.Parse(Length) - 2).ToString();
                    break;
                case "1588":
                    EdgeBcolor = "0";
                    break;
                default:
                    EdgeBcolor = "128";
                    break;
            }
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
            // (длина ширина кол-во имя материал вращение приоритет 
            // цвет кромки по сторонам тип кромки по сторонам) 
            //{ EdgeDcolor} {EdgeEcolor} {EdgeBcolor} {EdgeCcolor} {EdgeD} {EdgeE} {EdgeB} {EdgeC}
            // {EdgeCcolor} {EdgeBcolor} {EdgeDcolor} {EdgeEcolor} {EdgeC} {EdgeB} {EdgeD} {EdgeE}
            return $"{Length} {Width} {Count} {Name} {Material} 1 2 " +
                $" {EdgeDcolor} {EdgeEcolor} {EdgeBcolor} {EdgeCcolor} {EdgeD} {EdgeE} {EdgeB} {EdgeC}";
        }
        private bool Equals(Detail obj)
        {
            return Name == obj.Name && Length == obj.Length && Width == obj.Width && Material == obj.Material &&
                EdgeB == obj.EdgeB && EdgeC == obj.EdgeC && EdgeD == obj.EdgeD && EdgeE == obj.EdgeE &&
                EdgeBcolor == obj.EdgeBcolor && EdgeCcolor == obj.EdgeCcolor &&
                EdgeDcolor == obj.EdgeDcolor && EdgeEcolor == obj.EdgeEcolor;
        }
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
    }
}
