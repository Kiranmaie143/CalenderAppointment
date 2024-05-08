import { HttpClient } from '@angular/common/http';
import { Component, Input, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { IAppointment } from '../../../../shared/interfaces/IAppointment';
import { IAppointmentDetails } from '../../../../shared/interfaces/IAppointmentDetails';
import { HomeService } from '../../services/home.service';


@Component({
  selector: 'app-appointment-details',
  templateUrl: './appointment-details.component.html',
  styleUrls: ['./appointment-details.component.css']
})
export class appointmentDetailsComponent implements OnInit, OnChanges {

  @Input() appointment: IAppointment = {} as IAppointment;

  public appointmentDetails: IAppointmentDetails = {} as IAppointmentDetails;

  constructor(private homeService: HomeService) { }

  ngOnChanges(changes: SimpleChanges): void {
    this.getAppointmentDetails();
  }

  ngOnInit(): void {
    this.getAppointmentDetails();
  }

  getAppointmentDetails() {
    this.homeService.getAppointmentDetails(this.appointment.id)
      .subscribe(
        (result) => {
          this.appointmentDetails = result;
        },
        (error) => {
          console.error(error);
        }
      );
  }
}
