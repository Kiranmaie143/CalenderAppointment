import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { IAppointment } from '../../../../shared/interfaces/IAppointment';

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  public monthId: number = 1;
  public appointment: IAppointment = {} as IAppointment;


  constructor(private http: HttpClient) { }

  ngOnInit() { }

  onCalendarClicked(event: any) {
    this.monthId = event;
    this.appointment.id = 0;
  }

  onappointmentClicked(event: any) {
    this.appointment = event;
  }
}
