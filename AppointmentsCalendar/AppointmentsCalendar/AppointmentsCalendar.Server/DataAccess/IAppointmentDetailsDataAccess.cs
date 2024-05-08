

using Server.DTO;

namespace Server.DataAccess
{
    public interface IAppointmentDetailsDataAccess
    {
        public Task<AppointmentDetailsDto> GetById(int id);
    }
}
