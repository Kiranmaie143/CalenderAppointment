import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { CalendarComponent } from "./components/calendar/calendar.component";
import { HomeComponent } from "./components/home/home.component";
import { appointmentDetailsComponent } from "./components/appointment-details/appointment-details.component";
import { appointmentComponent } from "./components/appointment/appointment.component";
import { HomeService } from "./services/home.service";

@NgModule({
  declarations: [
    HomeComponent,
    CalendarComponent,
    appointmentComponent,
    appointmentDetailsComponent],
  imports: [CommonModule],
  providers: [HomeService],
  exports: [HomeComponent,
    CalendarComponent,
    appointmentComponent,
    appointmentDetailsComponent],
})
export class HomeModule { }
