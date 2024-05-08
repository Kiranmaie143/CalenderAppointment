using Server.DTO;

namespace Server.Business
{
    public interface IAppointmentBusiness
    {
        public Task<List<AppointmentDto>> GetAll(int monthId);
    }
}
