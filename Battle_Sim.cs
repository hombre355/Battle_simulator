using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Tektonux_Coding_Challenge
{
    public class BattleSimulator : IBattleSimulator
    {
        private Random _random = new Random();

        public ITransformer Battle(ITransformer transformer1, ITransformer transformer2)
        {
            // Simulate a battle with a random winner
            if (_random.Next(2) == 0)
            {
                transformer1.Wins++;
                transformer2.Losses++;
                return transformer1;
            }
            else
            {
                transformer2.Wins++;
                transformer1.Losses++;
                return transformer2;
            }
        }
    }
}
