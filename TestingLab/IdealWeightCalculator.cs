using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLab
{
    public class IdealWeightCalculator
    {
        public double Height { get; set; }
        public char Gender { get; set; }
        public double GetIdealWeight()
        {
            switch(Gender)
            {
                case 'm':
                    return (Height - 100) - ((Height - 150) / 4);
                case 'w':
                    return (Height - 100) - ((Height - 150) / 2);
                default:
                    return 0;
            }
        }
    }
}
