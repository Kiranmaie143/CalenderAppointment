import { HttpClient } from '@angular/common/http';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { IMonth } from '../../../../shared/interfaces/IMonth';

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

@Component({
  selector: 'app-calendar',
  templateUrl: './calendar.component.html',
  styleUrls: ['./calendar.component.css']
})
export class CalendarComponent implements OnInit {

  @Output()
  calendarClick = new EventEmitter<number>();

  months: IMonth[] = [];
  monthId: number = 0;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.months = [
      { Id: 1, Name: 'January' },
      { Id: 2, Name: 'February' },
      { Id: 3, Name: 'March' },
      { Id: 4, Name: 'April' },
      { Id: 5, Name: 'May' },
      { Id: 6, Name: 'June' },
      { Id: 7, Name: 'July' },
      { Id: 8, Name: 'August' },
      { Id: 9, Name: 'September' },
      { Id: 10, Name: 'October' },
      { Id: 11, Name: 'November' },
      { Id: 12, Name: 'December' }
    ];
    this.monthClicked(1);
  }

  monthClicked(monthId: number) {
    if (this.monthId !== monthId) {
      this.monthId = monthId;
      this.calendarClick.emit(monthId);
    }
  }
}
