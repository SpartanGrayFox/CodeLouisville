using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public double MathOperation(double first, double second, string operation)
        {
            switch (operation)
            {
                case "Add":
                    return (double)(first + second);
                case "Subtract":
                    return (double)(first - second);
                case "Multiply":
                    return (double)(first * second);
                case "Divide":
                    return (double)first / second;
                default:
                    return 0;
            }
        }
    }
    }

