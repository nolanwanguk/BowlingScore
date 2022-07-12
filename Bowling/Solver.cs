using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{

    public class Solver
    {
        private static List<int> NumPins=new List<int>();
        private void Extract(char[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                
                switch (args[i])
                {
                    case 'X':
                        NumPins.Add(10);
                        break;
                    case '-':
                        NumPins.Add(0);
                        break;
                    case '/':
                        NumPins.Add(10 - (int)char.GetNumericValue(args[i - 1]));
                        break;
                    default:
                        NumPins.Add((int)char.GetNumericValue(args[i]));
                        break;
                }
            }
        }
        public int Score(char[] args)
        {
            Extract(args);
            int score = 0;
            for(int i = 0; i < NumPins.Count-2; i++)
            {
                if(NumPins[i] == 10&& i < NumPins.Count - 2) { score += 10 + NumPins[i + 1] + NumPins[i + 2]; }
                else if (NumPins[i]+NumPins[i+1] == 10) { score+=10+ NumPins[i+2]; i++; }
                else { score += NumPins[i]; }

            }
            return score;
        }
    }
}
