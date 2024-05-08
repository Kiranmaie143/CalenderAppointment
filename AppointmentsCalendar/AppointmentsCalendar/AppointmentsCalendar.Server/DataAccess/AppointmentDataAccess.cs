

using Server.DTO;

namespace Server.DataAccess
{
    public class AppointmentDataAccess : IAppointmentDataAccess
    {
        public Task<List<AppointmentDto>> GetAll(int monthId)
        {
            var appointmentList = new List<AppointmentDto>()
            {
                new()
                {
                    Id = 1,
                    Title = "Appointment1",
                    StartTime = new DateTime(2024,1,1),
                    EndTime = new DateTime(2024,1,1).AddHours(1)
                },
                new()
                {
                    Id = 2,
                    Title = "Appointment2",
                    StartTime = new DateTime(2024,2,1),
                    EndTime = new DateTime(2024,2,1).AddHours(1)
                },
                new()
                {
                    Id = 3,
                    Title = "Appointment3",
                    StartTime = new DateTime(2024,2,1,15,30,1),
                    EndTime = new DateTime(2024,2,1).AddHours(1)
                }
            };
            var appointments = appointmentList.Where(x => x.StartTime.Month == monthId)?.ToList();
            return Task.FromResult(appointments ?? []);
        }
    }
}
