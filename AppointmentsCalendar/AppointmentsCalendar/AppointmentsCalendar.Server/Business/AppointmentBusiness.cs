
using Server.DataAccess;
using Server.DTO;

namespace Server.Business
{
    public class AppointmentBusiness: IAppointmentBusiness
    {
        private readonly IAppointmentDataAccess _appointmentDataAccess;

        public AppointmentBusiness(IAppointmentDataAccess appointmentDataAccess)
        {
            _appointmentDataAccess = appointmentDataAccess;
        }

        public Task<List<AppointmentDto>> GetAll(int monthId)
        {
            return _appointmentDataAccess.GetAll(monthId);
        }
    }
}
