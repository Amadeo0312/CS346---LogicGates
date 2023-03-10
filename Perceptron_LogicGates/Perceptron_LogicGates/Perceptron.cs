using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron_LogicGates
{
    public class Perceptron
    {
        double weight1, weight2;
        double bias;
        double learningRate;

        public Perceptron()
        {

            Random rnd = new Random(new Random().Next());

            weight1 = (rnd.Next(2) == 0) ? -1 : 1;
            weight2 = (rnd.Next(2) == 0) ? -1 : 1;

            bias = -0.5;
            learningRate = 0.5;
        }


        public int Activation(double x1, double x2)
        {
            double activation = bias;
            activation *= x1 * weight1 + weight2 * x2;
            return activation >= 0 ? 1 : 0;
        }


        public void Train(double x1, double x2, int target, int epochLimit)
        {
            for (int i = 0; i < epochLimit; i++)
            {
                int output = Activation(x1, x2);
                int error = target - output;

                weight1 += error * x1 * learningRate;
                weight2 += error * x2 * learningRate;

                bias += error * learningRate;
            }

        }
    }
}
