import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AstroService } from '../services/astro.service';
import Chart from 'chart.js/auto';

@Component({
  selector: 'app-signal-chart',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './signal-chart.html',
  styleUrls: ['./signal-chart.css']
})
export class SignalChartComponent {

  chart: any;
  planetDetected: boolean | null = null;
  confidence: number | null = null;
  isDarkTheme = true; // ← ADD THIS LINE

  constructor(private astro: AstroService) {}

  generateSignal(){

    this.astro.getSignal().subscribe((res:any)=>{

      const data = res.signal;

      this.planetDetected = res.planetDetected;
      this.confidence = res.confidence;

      if(this.chart){
        this.chart.destroy();
      }

      this.chart = new Chart("signalCanvas",{
        type:'line',
        data:{
          labels:data.map((_:any,i:number)=>i),
          datasets:[
            {
              label:'Star Brightness',
              data:data,
              borderColor:'#00d4ff',
              backgroundColor:'rgba(0,212,255,0.2)',
              tension:0.3,
              pointRadius:3
            }
          ]
        },
        options:{
          responsive:true,
          plugins:{
            legend:{
              display:true,
              labels:{
                color:'#444'
              }
            }
          },
          scales:{
            x:{
              title:{
                display:true,
                text:'Time',
                color:'#444',
                font:{ size:14, weight:'bold' }
              },
              ticks:{ color:'#444' }
            },
            y:{
              title:{
                display:true,
                text:'Brightness',
                color:'#444',
                font:{ size:14, weight:'bold' }
              },
              ticks:{ color:'#444' }
            }
          }
        }
      });

    });

  }

}