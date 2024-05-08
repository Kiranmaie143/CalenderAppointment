using Server.DTO;

namespace Server.Business
{
    public interface IAppointmentDetailsBusiness
    {
        public Task<AppointmentDetailsDto> GetById(int appointmentId);
    }
}
