🌌 Quantum Exoplanet Detection Lab

A cloud-based web application that simulates stellar brightness signals and detects potential exoplanets using the transit detection method.

This project demonstrates how modern web technologies can be used to build scientific tools that analyze astronomical data and visualize planetary transit signals.

The system combines a modern Angular frontend, an ASP.NET Core API backend, and cloud deployment using Docker, Railway, and Netlify.

🚀 Live Application

Frontend (Angular UI)
https://quantum-exoplanet-detection-lab.netlify.app

Backend API (ASP.NET Core – Railway)
https://quantum-exoplanet-detection-lab-production.up.railway.app

API Documentation (Swagger)
https://quantum-exoplanet-detection-lab-production.up.railway.app/swagger

🛰️ What Problem Does This Solve?

Astronomers often analyze stellar brightness over time to identify potential planets orbiting distant stars.

When a planet passes in front of a star, it causes a small temporary drop in brightness. This is called the Transit Method.

This system simulates that process and automatically detects possible transit events.

Example light curve:

Brightness
1.00 ────────────────
      \           /
       \_________/   ← Planet transit

A drop in brightness suggests that a planet may have passed in front of the star.

✨ Key Features

• Generate simulated star brightness signals
• Detect possible exoplanet transit events
• Visualize signals using interactive charts
• REST API with Swagger documentation
• Cloud deployment with Docker
• Fully working frontend-backend architecture
• Cross-platform system accessible from anywhere

🧠 How the System Works

1️⃣ The frontend requests signal data from the backend API.

2️⃣ The backend generates simulated stellar brightness measurements.

3️⃣ A detection service analyzes the signal to identify possible transit dips.

4️⃣ The frontend visualizes the light curve using charts.

5️⃣ The system displays whether a planet was detected and the confidence level.

🏗️ System Architecture
User Browser
      │
      ▼
Angular Frontend (Netlify)
https://quantum-exoplanet-detection-lab.netlify.app
      │
      ▼
ASP.NET Core API (Railway)
https://quantum-exoplanet-detection-lab-production.up.railway.app
      │
      ▼
Signal Generation + Planet Detection Services
⚙️ Technology Stack
Frontend

• Angular
• TypeScript
• Chart.js
• HTML5 / CSS3

Backend

• ASP.NET Core Web API
• C#
• Swagger (OpenAPI documentation)

Cloud & DevOps

• Docker
• Railway (Backend hosting)
• Netlify (Frontend hosting)
• GitHub (Version control)

📂 Project Structure
Quantum-Exoplanet-Detection-Lab
│
├── quantum-exoplanet-ui
│   ├── src
│   ├── angular.json
│   └── package.json
│
├── QuantumAstroLabAPI
│   ├── Controllers
│   ├── Services
│   ├── Program.cs
│   ├── Startup.cs
│   └── QuantumAstroLabAPI.csproj
│
└── Dockerfile
🔌 API Endpoints
Generate Star Signal
GET /api/signal

This endpoint generates simulated brightness data and analyzes it.

Example response:

{
  "signal": [1.0, 0.99, 0.97, 0.95, 0.99],
  "planetDetected": true,
  "confidence": 0.82
}

Where:

Field	Description
signal	Brightness values of the star over time
planetDetected	Indicates if a possible exoplanet was detected
confidence	Probability that the detected signal represents a real transit
🌍 Applications of This System
Educational Astronomy Platform

Students can use this system to learn how exoplanets are detected using light curve analysis.

Research Prototyping

Developers and researchers can prototype signal-processing algorithms before applying them to real telescope datasets.

Astronomical Data Visualization

The application provides a simple way to visualize stellar brightness time-series data.

Simulation of Telescope Observations

The generated signals mimic how telescopes collect brightness measurements.

Demonstration of Scientific Cloud Systems

The project shows how modern technologies can be used to build cloud-based scientific analysis platforms.

Teaching Signal Processing Concepts

The system can help demonstrate pattern recognition, anomaly detection, and time-series analysis.

💻 Running the Project Locally
Backend

Navigate to the API folder:

cd QuantumAstroLabAPI

Run the backend:

dotnet restore
dotnet run

Backend will start at:

https://localhost:5001

Swagger documentation:

https://localhost:5001/swagger
Frontend

Navigate to the Angular project:

cd quantum-exoplanet-ui

Install dependencies:

npm install

Run the development server:

ng serve

Frontend will run at:

http://localhost:4200
🐳 Docker Deployment

Build the container:

docker build -t quantum-astro-api .

Run the container:

docker run -p 8080:8080 quantum-astro-api
📊 Future Improvements

• Use real astronomical datasets
• Implement machine learning for transit detection
• Support multiple star systems
• Store historical observations in a database
• Create a telescope observation dashboard
• Improve noise filtering in signals

🔭 Real-World Inspiration

This project is inspired by real astronomical missions such as:

• NASA Kepler Mission
• TESS (Transiting Exoplanet Survey Satellite)
• Transit Photometry Method used in astrophysics

These missions use brightness variations of stars to discover new planets.

👨‍💻 Author

Developed as a full-stack scientific web application demonstrating:

• Cloud architecture
• API development
• Data visualization
• Scientific simulation

📜 License

This project is released under the MIT License.
