using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordiz_github_calculator_sample
{
    public class Addition
    {
        public double  Add(double num1, double num2)
        { 
           double sum = num1 + num2;

            return sum;
        }
               
    }
}
