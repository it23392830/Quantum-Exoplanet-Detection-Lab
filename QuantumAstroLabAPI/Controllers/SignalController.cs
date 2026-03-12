using Microsoft.AspNetCore.Mvc;
using QuantumAstroLabAPI.Services;
using QuantumAstroLabAPI.Models;

namespace QuantumAstroLabAPI.Controllers
{
    [ApiController]
    [Route("api/signal")]
    public class SignalController : ControllerBase
    {
        private readonly SignalGeneratorService generator;
        private readonly PlanetDetectionService detector;

        public SignalController(
            SignalGeneratorService g,
            PlanetDetectionService d)
        {
            generator = g;
            detector = d;
        }

        [HttpGet]
        public IActionResult GenerateSignal(double noise = 0.01)
        {
            var signal = generator.GenerateSignal(100, noise);

            var result = detector.Detect(signal);

            DetectionResult response = new DetectionResult
            {
                PlanetDetected = result.detected,
                Confidence = result.confidence,
                Signal = signal
            };

            return Ok(response);
        }
    }
}