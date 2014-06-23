using System;
using Terraria;

namespace AIO
{
    public class Backup
    {
        public int X;
        public int Y;
        public Tile Tile;
        public Backup(int x, int y)
        {
            X = x;
            Y = y;
            Tile = Main.tile[x, y];
        }
    }
    public class Report
    {
        public int X;
        public int Y;
        public string Name;
        public DateTime Date;
        public Report(int x, int y, string name, DateTime date)
        {
            X = x;
            Y = y;
            Name = name;
            Date = date;
        }
    }
}
