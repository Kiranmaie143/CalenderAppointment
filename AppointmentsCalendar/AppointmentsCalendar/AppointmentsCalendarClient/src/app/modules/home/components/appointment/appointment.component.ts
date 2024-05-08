import { Component, EventEmitter, Input, OnChanges, OnInit, Output, SimpleChanges } from '@angular/core';
import { IAppointment } from '../../../../shared/interfaces/IAppointment';
import { HomeService } from '../../services/home.service';

@Component({
  selector: 'app-appointment',
  templateUrl: './appointment.component.html',
  styleUrls: ['./appointment.component.css']
})
export class appointmentComponent implements OnInit, OnChanges {
  public appointments: IAppointment[] = [];
  public appointmentId: number = 0;

  @Input()
  monthId: number = 0;

  @Output()
  appointmentClick = new EventEmitter<IAppointment>();

  constructor(private homeService: HomeService) { }

  ngOnChanges(changes: SimpleChanges): void {
    this.appointmentId = 0;
    this.getAppointments();
  }

  ngOnInit() {
    this.getAppointments();
  }

  getAppointments() {
    this.homeService.getAppointments(this.monthId)
      .subscribe(
        (data) => {
          this.appointments = data;
        },
        (error) => {
          console.error(error);
        }
      );
  }

  appointmentClicked(appointment: IAppointment) {
    this.appointmentId = appointment.id;
    this.appointmentClick.emit(appointment);
  }
}
