using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Twitty_Brandon_Lab1_2910
{
    public class VideoGame : IComparable<VideoGame>
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public string NA_Sales { get; set; }
        public string EU_Sales { get; set; }
        public string JP_Sales { get; set; }
        public string Other_Sales { get; set; }
        public string Global_Sales { get; set; }

        public VideoGame() { }
        
        public VideoGame(string name, string platform, string year, string genre, string publisher, string na_sales, string eu_sales, string jp_sales, string other_sales, string global_sales)
        {
            this.Name = name;
            this.Platform = platform;
            this.Year = year;
            this.Genre = genre;
            this.Publisher = publisher;
            this.NA_Sales = na_sales;
            this.EU_Sales = eu_sales;
            this.JP_Sales = jp_sales;
            this.Other_Sales = other_sales;
            this.Global_Sales = global_sales;
        }

        public int CompareTo(VideoGame other)
        {
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            string msg = $"Name: {this.Name}\n";
            msg += $"Platform: {this.Platform}\n";
            msg += $"Year: {this.Year}\n";
            msg += $"Genre: {this.Genre}\n";
            msg += $"Publisher: {this.Publisher}\n";
            msg += $"NA Sales: {this.NA_Sales}\n";
            msg += $"EU Sales: {this.EU_Sales}\n";
            msg += $"JP Sales: {this.JP_Sales}\n";
            msg += $"Other Sales: {this.Other_Sales}\n";
            msg += $"Global Sales: {this.Global_Sales}\n";
            msg += "---------------------------------------";
            return msg;
        }
    }
}
