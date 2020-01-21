using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace GetDataFromDataBase
{
    public class Detail : IComparable<Detail>
    {
        string Name { get; set; }//имя детали
        string Length;//длина детали
        string Width;// ширина детали
        string Material = "NoMaterial";// материал детали
        // типы кромок по сторонам детали
        string EdgeB = string.Empty;
        string EdgeC = string.Empty;
        string EdgeD = string.Empty;
        string EdgeE = string.Empty;
        //цвет кромки по сторонам
        string EdgeBcolor = "0";
        string EdgeCcolor = "0";
        string EdgeDcolor = "0";
        string EdgeEcolor = "0";
        string Thinkness = string.Empty;
        public int Count { get; private set; }
        public Detail(string name, string length, string width, string material, string edgeB, string edgeC, string edgeD, string edgeE)
        {
            GetMaterialFromDB(material);
            SetName(name);
            Length = length;
            Width = width;
            //Material = SetMaterialShort(material);
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
                    EdgeEcolor = "8388736";
                    Width = (int.Parse(Width) - 2).ToString();
                    break;
                case "1588":
                    EdgeE = "1мм";
                    EdgeEcolor = "0";
                    break;
                default:
                    EdgeE = "0,4мм";
                    EdgeEcolor = "32768";
                    break;
            }
        }

        private void SetEdgeD(string edgeD)
        {
            switch (edgeD)
            {
                case "1582":
                    EdgeD = "2мм";
                    EdgeDcolor = "8388736";
                    Width = (int.Parse(Width) - 2).ToString();
                    break;
                case "1588":
                    EdgeD = "1мм";
                    EdgeDcolor = "0";
                    break;
                default:
                    EdgeD = "0,4мм";
                    EdgeDcolor = "32768";
                    break;
            }
        }

        private void SetEdgeC(string edgeC)
        {
            switch (edgeC)
            {
                case "1582":
                    EdgeC = "2мм";
                    EdgeCcolor = "8388736";
                    Length = (int.Parse(Length) - 2).ToString();
                    break;
                case "1588":
                    EdgeC = "1мм";
                    EdgeCcolor = "0";
                    break;
                default:
                    EdgeC = "0,4мм";
                    EdgeCcolor = "32768";
                    break;
            }
        }

        private void SetEdgeB(string edgeB)
        {
            switch (edgeB)
            {
                case "1582":
                    EdgeB = "2мм";
                    EdgeBcolor = "8388736";
                    Length = (int.Parse(Length) - 2).ToString();
                    break;
                case "1588":
                    EdgeB = "1мм";
                    EdgeBcolor = "0";
                    break;
                default:
                    EdgeB = "0,4мм";
                    EdgeBcolor = "32768";
                    break;
            }
        }
        private string SetMaterialShort(string material)
        {
            switch (material)
            {
                case "281":
                    return "Русламинат" + "•" + "белый";
                case "1606":
                    return "Русламинат" + "•" + "черный";
                case "314":
                    return "Хдф";
                case "492":
                    return "Дсп" + '•' + "белое";
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
                case "1600":
                    return "Дсп" + '•' + "egger";
                case "1603":
                    return "Alvic" + '•' + "белый";
                case "1608":
                    return "Egger" + '•' + "желтый" + '•' + "бриллиант";
                case "1610":
                    return "Alvic" + '•' + "белый" + '•' + "глянец";
                case "1609":
                    return "Agt" + '•' + "черный" + '•' + "матовый";
                case "1611":
                    return "Egger" + '•' + "синяя" + '•' + "глубина";
                case "1612":
                    return "Egger" + '•' + "дуб" + '•' + "сорано";
                case "1623":
                    return "Диамант" + '•' + "серый";
                case "1626":
                    return "Кашемир" + '•' + "серый";
                case "1625":
                    return "Серый" + '•' + "кубанит";
                case "1629":
                    return "Дуб" + '•' + "гладстоун";
                case "1631":
                    return "Egger" + '•' + "белая" + '•' + "древесина";
                case "1618":
                    return "Alvic" + '•' + "syncron";
                case "1617":
                    return "Alvic" + '•' + "антрацит";
                case "1622":
                    return "Smart" + '•' + "красный";
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
            return $"{Length} {Width} {Count} {Name} {Material} 1";
        }
        public string ShowToCuttingWithEdge()
        {
            // возврат строки в формате для cutting 
            // (длина ширина кол-во имя материал вращение приоритет 
            // цвет кромки по сторонам тип кромки по сторонам) 
            //{ EdgeDcolor} {EdgeEcolor} {EdgeBcolor} {EdgeCcolor} {EdgeD} {EdgeE} {EdgeB} {EdgeC}
            // {EdgeCcolor} {EdgeBcolor} {EdgeDcolor} {EdgeEcolor} {EdgeC} {EdgeB} {EdgeD} {EdgeE}
            string b = "0";
            string c = "0";
            string d = "0";
            string e = "0";
            string rotation = "0";
            if (Material.Contains("Двп") || Name.Contains("ящик"))
                rotation = "1";
            if (EdgeB != string.Empty && !Name.Contains("ящик"))
                b = "1";
            if (EdgeC != string.Empty && !Name.Contains("ящик"))
                c = "1";
            if (EdgeD != string.Empty && !Name.Contains("ящик"))
                d = "1";
            if (EdgeE != string.Empty && !Name.Contains("ящик"))
                e = "1";
            return $"{Length} {Width} {Count} {Name} {Material} {rotation} 2 {EdgeCcolor} {EdgeBcolor} {EdgeDcolor} {EdgeEcolor} {c} {b} {d} {e}";
        }
        private bool Equals(Detail obj)
        {
            return Name == obj.Name && Length == obj.Length && Width == obj.Width && Material == obj.Material &&
                EdgeB == obj.EdgeB && EdgeC == obj.EdgeC && EdgeD == obj.EdgeD && EdgeE == obj.EdgeE;
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

        public int CompareTo(Detail det)
        {
            return Material.CompareTo(det.Material);
        }
        private void GetMaterialFromDB(string material)
        {
            List<Material> materials = new List<Material>();
            string adressDB = @"Provider=Microsoft.Jet.OLEDB.4.0;
                               Data Source=C:\Program Files (x86)\GeoS\K3-Мебель-ПКМ\Data\PKM\tmguidesV6.mdb";
            OleDbConnection connection = new OleDbConnection(adressDB);
            using (connection)
            {
                connection.OpenAsync();
                string query = "SELECT PriceID, MName FROM TPrice WHERE MatID IN (SELECT MatID FROM TMat WHERE MatName LIKE 'ДСП%' OR MatName LIKE 'AGT%' OR MatName LIKE 'Alvic%' OR MatName LIKE 'ДВП%')";// номер MatID берется в типах материалов в базе к-3

                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string number = reader[0].ToString();
                    string name = reader[1].ToString();
                    materials.Add(new Material(name, number));
                }
                connection.Close();
                command.Dispose();
            }
            foreach (var item in materials)
            {
                if (item.Number == material)
                {
                    Material = item.Name;
                }
            }
        }
    }
}
