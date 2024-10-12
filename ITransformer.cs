//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Tektonux_Coding_Challenge
{
    public interface ITransformer
    {
        string Name { get; }
        string Faction { get; }
        int Wins { get; set; }
        int Losses { get; set; }
        double WinRate { get; }
    }
}
