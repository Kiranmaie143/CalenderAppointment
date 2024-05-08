
using Server.DataAccess;
using Server.DTO;

namespace Server.Business
{
    public class AppointmentDetailsBusiness : IAppointmentDetailsBusiness
    {
        private readonly IAppointmentDetailsDataAccess _appointmentDetailsDataAccess;

        public AppointmentDetailsBusiness(IAppointmentDetailsDataAccess appointmentDetailsDataAccess)
        {
            _appointmentDetailsDataAccess = appointmentDetailsDataAccess;
        }

        public Task<AppointmentDetailsDto> GetById(int appointmentId)
        {
            return _appointmentDetailsDataAccess.GetById(appointmentId);
        }
    }
}
