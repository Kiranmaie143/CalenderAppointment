import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { finalize, Observable } from "rxjs";
import { IAppointment } from "../../../shared/interfaces/IAppointment";
import { IAppointmentDetails } from "../../../shared/interfaces/IAppointmentDetails";

@Injectable({
  providedIn: 'root',
})
export class HomeService {

  constructor(private http: HttpClient) {
  }

  getAppointments(monthId: number): Observable<IAppointment[]> {
    return this.http.get<IAppointment[]>('https://localhost:7054/api/appointments?monthId=' + monthId).pipe();
  }

  getAppointmentDetails(appointmentId: number): Observable<IAppointmentDetails> {
    return this.http.get<IAppointmentDetails>("https://localhost:7054/api/appointments/" + appointmentId + "/details");
  }
}
