using System.Collections.Generic;

namespace QuantumAstroLabAPI.Models
{
    public class DetectionResult
    {
        public bool PlanetDetected { get; set; }
        public double Confidence { get; set; }
        public List<double> Signal { get; set; }
    }
}