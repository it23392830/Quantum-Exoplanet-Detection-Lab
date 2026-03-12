# 🌌 Quantum Exoplanet Detection Lab

<div align="center">

![Status](https://img.shields.io/badge/status-live-brightgreen?style=for-the-badge)
![Angular](https://img.shields.io/badge/Angular-17-DD0031?style=for-the-badge&logo=angular&logoColor=white)
![.NET](https://img.shields.io/badge/.NET_Core-API-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Docker](https://img.shields.io/badge/Docker-deployed-2496ED?style=for-the-badge&logo=docker&logoColor=white)
![License](https://img.shields.io/badge/license-MIT-blue?style=for-the-badge)

**A cloud-based web application that simulates stellar brightness signals and detects potential exoplanets using the transit detection method.**

[🚀 Live App](https://quantum-exoplanet-detection-lab.netlify.app) &nbsp;·&nbsp;
[📡 API](https://quantum-exoplanet-detection-lab-production.up.railway.app) &nbsp;·&nbsp;
[📖 Swagger Docs](https://quantum-exoplanet-detection-lab-production.up.railway.app/swagger)

</div>

---

## 🔭 What Is This?

Astronomers discover planets around distant stars not by seeing them directly — but by watching a star's brightness over time.

When a planet passes in front of its star (called a **transit**), it blocks a tiny fraction of the light. This creates a brief, faint dip in brightness:

```
Brightness
1.00  ──────────────────────────────────
                  ╲               ╱
                   ╲_____________╱   ← Planet transit dip
```

> A drop in brightness tells us: *something passed in front of that star.*

This system **simulates that exact process** — generating a realistic brightness signal, analysing it for transit patterns, and reporting whether a planet was likely detected, along with a confidence score.

---

## 🌐 Live Application

| Layer | URL |
|---|---|
| 🖥️ Frontend (Angular · Netlify) | https://quantum-exoplanet-detection-lab.netlify.app |
| ⚙️ Backend API (ASP.NET Core · Railway) | https://quantum-exoplanet-detection-lab-production.up.railway.app |
| 📖 API Documentation (Swagger) | https://quantum-exoplanet-detection-lab-production.up.railway.app/swagger |

---

## ✨ Key Features

- 🌠 &nbsp; Generate simulated star brightness signals (light curves)
- 🔍 &nbsp; Automatic exoplanet transit detection
- 📊 &nbsp; Interactive Chart.js visualisation of the light curve
- 🎨 &nbsp; NASA-inspired dark / light theme dashboard
- 📡 &nbsp; REST API with Swagger / OpenAPI documentation
- 🐳 &nbsp; Dockerised backend, deployed on Railway + Netlify
- 🌍 &nbsp; Fully cloud-hosted and accessible from any browser

---

## 🧠 How the System Works

```
① User clicks "Generate Star Signal"
        │
        ▼
② Angular frontend calls the backend API
        │
        ▼
③ ASP.NET Core generates simulated brightness measurements
        │
        ▼
④ Detection service scans the signal for transit dips
        │
        ▼
⑤ Result returned: planetDetected + confidence score
        │
        ▼
⑥ Frontend renders the light curve chart + detection card
```

### Step by step

| Step | What Happens |
|---|---|
| **Signal Generation** | The backend creates 100 brightness readings that mimic a real telescope observation, including realistic noise |
| **Transit Injection** | A simulated planetary transit dip is randomly added to some signals |
| **Detection Analysis** | The service checks for characteristic brightness drops that match transit patterns |
| **Confidence Scoring** | A score from `0.0` to `1.0` is calculated — how likely it is that the dip is a real transit, not just noise |
| **Visualisation** | The Angular frontend plots the full light curve and displays the detection verdict |

---

## 🏗️ System Architecture

```
┌─────────────────────────────────────────────────────┐
│                    User Browser                      │
└───────────────────────┬─────────────────────────────┘
                        │
                        ▼
┌─────────────────────────────────────────────────────┐
│         Angular Frontend  (Netlify CDN)              │
│   • Signal chart visualisation  (Chart.js)           │
│   • Detection result card                            │
│   • Dark / Light theme toggle                        │
└───────────────────────┬─────────────────────────────┘
                        │  GET /api/signal
                        ▼
┌─────────────────────────────────────────────────────┐
│        ASP.NET Core Web API  (Railway + Docker)      │
│   • SignalController  →  GET /api/signal             │
│   • SignalGenerationService                          │
│   • PlanetDetectionService                           │
│   • Swagger / OpenAPI docs                           │
└─────────────────────────────────────────────────────┘
```

---

## ⚙️ Technology Stack

### Frontend
| Technology | Purpose |
|---|---|
| Angular 17 (standalone) | UI framework |
| TypeScript | Language |
| Chart.js | Light curve visualisation |
| HTML5 / CSS3 | Layout and theming |

### Backend
| Technology | Purpose |
|---|---|
| ASP.NET Core Web API | REST API framework |
| C# | Language |
| Swagger / OpenAPI | API documentation |

### Cloud & DevOps
| Technology | Purpose |
|---|---|
| Docker | Containerisation |
| Railway | Backend hosting |
| Netlify | Frontend hosting |
| GitHub | Version control |

---

## 📡 API Reference

### `GET /api/signal`

Generates a simulated stellar brightness signal and returns a transit detection result.

**Example Response**
```json
{
  "signal": [1.0, 0.998, 0.995, 0.981, 0.974, 0.982, 0.996, 1.001],
  "planetDetected": true,
  "confidence": 0.82
}
```

**Response Fields**

| Field | Type | Description |
|---|---|---|
| `signal` | `number[]` | Array of normalised brightness values over time |
| `planetDetected` | `boolean` | `true` if a transit dip was detected |
| `confidence` | `number` | Probability score `0.0 – 1.0` that the signal is a real transit |

> Full interactive docs at: https://quantum-exoplanet-detection-lab-production.up.railway.app/swagger

---

## 📂 Project Structure

```
Quantum-Exoplanet-Detection-Lab/
│
├── quantum-exoplanet-ui/              # Angular frontend
│   ├── src/
│   │   └── app/
│   │       ├── signal-chart/          # Main dashboard component
│   │       │   ├── signal-chart.ts
│   │       │   ├── signal-chart.html
│   │       │   └── signal-chart.css
│   │       └── services/
│   │           └── astro.service.ts   # API communication
│   ├── angular.json
│   └── package.json
│
├── QuantumAstroLabAPI/                # ASP.NET Core backend
│   ├── Controllers/
│   ├── Services/
│   ├── Program.cs
│   └── QuantumAstroLabAPI.csproj
│
└── Dockerfile                         # Docker configuration
```

---

## 💻 Running Locally

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Node.js 18+](https://nodejs.org/)
- [Angular CLI](https://angular.io/cli) — `npm install -g @angular/cli`

### 1 — Start the Backend

```bash
cd QuantumAstroLabAPI
dotnet restore
dotnet run
```

Backend runs at → `https://localhost:5001`  
Swagger UI → `https://localhost:5001/swagger`

### 2 — Start the Frontend

```bash
cd quantum-exoplanet-ui
npm install
ng serve
```

Frontend runs at → `http://localhost:4200`

---

## 🐳 Docker Deployment

```bash
# Build the container image
docker build -t quantum-astro-api .

# Run the container
docker run -p 8080:8080 quantum-astro-api
```

---

## 🌍 Applications & Use Cases

| Use Case | Description |
|---|---|
| 🎓 **Educational Platform** | Helps students learn how exoplanets are detected via light curve analysis |
| 🔬 **Research Prototyping** | Prototype signal-processing algorithms before applying them to real telescope data |
| 📊 **Data Visualisation** | Simple, accessible way to visualise stellar brightness time-series data |
| 🛸 **Telescope Simulation** | Mimics how space telescopes collect and transmit brightness measurements |
| ☁️ **Cloud Architecture Demo** | Demonstrates modern cloud-based scientific application design |
| 📚 **Signal Processing Teaching** | Illustrates pattern recognition, anomaly detection, and time-series analysis |

---

## 🔭 Real-World Inspiration

This project is inspired by real NASA missions that use the same transit detection principle:

| Mission | Description |
|---|---|
| [NASA Kepler Mission](https://www.nasa.gov/mission_pages/kepler/main/index.html) | Discovered 2,600+ confirmed exoplanets using stellar brightness monitoring |
| [TESS](https://www.nasa.gov/tess-transiting-exoplanet-survey-satellite) | Transiting Exoplanet Survey Satellite — currently scanning 200,000+ stars |
| Transit Photometry | The core scientific method this system simulates |

---

## 🚀 Future Improvements

- [ ] Integrate real astronomical datasets (NASA Kepler public data)
- [ ] Implement ML-based transit detection model
- [ ] Support multiple star system simulations
- [ ] Store and compare historical observations in a database
- [ ] Add noise filtering controls
- [ ] Multi-wavelength signal analysis

---

## 👨‍💻 Author

Developed as a full-stack scientific web application demonstrating cloud architecture, REST API design, data visualisation, and scientific simulation using modern web technologies.

---

## 📜 License

This project is released under the [MIT License](LICENSE).

---

<div align="center">

Made with ❤️ and a love for space exploration

⭐ If you found this interesting, give it a star!

</div>
