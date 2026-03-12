using System.Collections.Generic;
using System.Linq;

namespace QuantumAstroLabAPI.Services
{
    public class PlanetDetectionService
    {
        public (bool detected, double confidence) Detect(List<double> signal)
        {
            double min = signal.Min();

            bool detected = min < 0.98;

            double confidence = detected
                ? (0.98 - min) * 100
                : 0;

            return (detected, confidence);
        }
    }
}