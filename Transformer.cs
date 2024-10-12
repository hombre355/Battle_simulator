//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Tektonux_Coding_Challenge
{
    public class Transformer : ITransformer
    {
        public string Name { get; private set; }
        public string Faction { get; private set; }
        public int Wins { get; set; }
        public int Losses { get; set; }

        public Transformer(string name, string faction)
        {
            Name = name;
            Faction = faction;
        }

        public double WinRate => Wins + Losses > 0 ? (double)Wins / (Wins + Losses) : 0;

        public override string ToString()
        {
            return $"Name: {Name}, Faction: {Faction}, Wins: {Wins}, Losses: {Losses}, Win Rate: {WinRate:P}";
        }
    }
}
