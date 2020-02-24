using System;
using System.Collections.Generic;
using System.Text;

namespace Perceptron
{
    public class Data
    {
        public double[] inputs;
        public double output;
        public Data(int size)
        {
            inputs = new double[size];
        }
    }
}
