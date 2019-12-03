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
            Material = material;
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
        public string Show()
        {
            return $"{Length} {Width} {Count} {Name} 1 2 {Material} " +
                $"{EdgeB} {EdgeC} {EdgeD} {EdgeE} {EdgeBcolor} {EdgeCcolor} {EdgeDcolor} {EdgeEcolor}";
        }
    }
}
