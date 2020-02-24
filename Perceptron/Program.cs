using System;

namespace Perceptron
{
    class Program
    {
        static void Main(string[] args)
        {
            Perceptron neuNet = new Perceptron(6);
            Data[] datas = new Data[4];
            datas[0] = new Data(3);
            datas[1] = new Data(3);
            datas[2] = new Data(3);
            datas[3] = new Data(3);
            datas[0].inputs = new double[]{ 1, 0, 1};
            datas[0].output = 1;
            datas[1].inputs = new double[] { 0, 0, 1 };
            datas[1].output = 0;
            datas[2].inputs = new double[] { 1, 1, 0 };
            datas[2].output = 1;
            datas[3].inputs = new double[] { 0, 0, 0};
            datas[3].output = 0;

            Data testData = new Data(3);
            testData.inputs = new double[] { 0, 0, 0 };
            neuNet.Train(10000, datas);
            neuNet.Evaluate(testData);
        }
    }
}
