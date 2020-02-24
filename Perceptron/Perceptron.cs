using System;

namespace Perceptron
{
    public class Perceptron
    {
        private double[] inputs;
        private double[] weights;
        private double output;
        public double learnrate = 0.1;
        private double error = 1;

        public Perceptron(int size)
        {
            Random r = new Random(1);
            inputs = new double[size + 1];
            inputs[size] = 1;
            weights = new double[size + 1];

            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = r.NextDouble();
            }
        }

        private void FeedForward()
        {
            double sum = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                sum += weights[i] * inputs[i];
            }
            //ReLU on total error
            output = (sum >= 0) ? 1 : 0;
        }

        private void FeedBack(double expected)
        {
            error = expected - output;
            for (int i = 0; i < inputs.Length; i++)
            {
                weights[i] += learnrate * error * inputs[i];
            }
        }

        public void Train(int epochs, Data [] datas)
        {
            int counter = 0;
            while (counter++ < epochs)
            {
                for (int j = 0; j < datas.Length; j++)
                {
                    for (int k = 0; k < datas[j].inputs.Length; k++)
                    {
                        inputs[k] = datas[j].inputs[k];
                    }
                    FeedForward();
                    FeedBack(datas[j].output);
                }
            }
        }


        public void Evaluate(Data d)
        {
            for (int i = 0; i < d.inputs.Length; i++)
            {
                inputs[i] = d.inputs[i];
            }
            FeedForward();
            Console.WriteLine("Estimated: " + output);
        }
    }
}
