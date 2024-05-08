using Server.DTO;

namespace Server.DataAccess
{
    public interface IAppointmentDataAccess
    {
        public Task<List<AppointmentDto>> GetAll(int monthId);
    }
}
