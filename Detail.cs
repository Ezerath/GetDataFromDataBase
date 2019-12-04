namespace GetDataFromDataBase
{
    public class Detail
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
                EdgeB = "1";
                if (edgeB == "1582")
                    EdgeBcolor = "8388736";
                else
                    EdgeBcolor = "0";
            }
            else
            {
                EdgeB = "0";
                EdgeBcolor = "0";
            }
            if (edgeC != "0")
            {
                EdgeC = "1";
                if (edgeC == "1582")
                    EdgeCcolor = "8388736";
                else
                    EdgeCcolor = "0";
            }
            else
            {
                EdgeC = "0";
                EdgeCcolor = "0";
            }
            if (edgeD != "0")
            {
                EdgeD = "1";
                if (edgeD == "1582")
                    EdgeDcolor = "8388736";
                else
                    EdgeDcolor = "0";
            }
            else
            {
                EdgeD = "0";
                EdgeDcolor = "0";
            }
            if (edgeE != "0")
            {
                EdgeE = "1";
                if (edgeE == "1582")
                    EdgeEcolor = "8388736";
                else
                    EdgeEcolor = "0";
            }
            else
            {
                EdgeE = "0";
                EdgeEcolor = "0";
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
            // длина ширина кол-во имя материал вращение приоритет 
            // цвет кромки по сторонам тип кромки по сторонам
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
