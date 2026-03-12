using System;
using System.Collections.Generic;
using System.Linq;
using QuantumAstroLabAPI.Models;

namespace QuantumAstroLabAPI.Services
{
    public class SignalGeneratorService
    {
        private Random random = new Random();

        public List<double> GenerateSignal(int points, double noiseLevel)
        {
            List<double> signal = new List<double>();

            for (int i = 0; i < points; i++)
            {
                double brightness = 1.0;

                // simulate planet transit dip
                brightness -= 0.02 * Math.Exp(-Math.Pow(i - 50, 2) / 200);

                // add telescope noise
                brightness += (random.NextDouble() - 0.5) * noiseLevel;

                signal.Add(brightness);
            }

            return signal;
        }
    }
}