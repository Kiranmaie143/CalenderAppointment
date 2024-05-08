

using Server.DTO;

namespace Server.DataAccess
{
    public class AppointmentDetailsDataAccess : IAppointmentDetailsDataAccess
    {
        public Task<AppointmentDetailsDto> GetById(int appointmentId)
        {
            var attendies = new List<string>
            {
                "Sunil Sahoo",
                "Swati Gupta",
                "Sriknath"
            };

            var appointmentDetailsList = new List<AppointmentDetailsDto>()
            {
                new AppointmentDetailsDto()
                {
                    Id = 1,
                    AppointmentId = 1,
                    Organizer = "Kiran",
                    Attendies = attendies,
                    Description = "This is body for appointment 1 from Kiran" 
                },
                new AppointmentDetailsDto()
                {
                    Id = 2,
                    AppointmentId = 2,
                    Organizer = "Bob",
                    Attendies = attendies,
                    Description = "This is body for appointment 2 from Bob"
                },
                new AppointmentDetailsDto()
                {
                    Id = 3,
                    AppointmentId = 3,
                    Organizer = "Sunil",
                    Attendies = attendies,
                    Description = "This is body for appointment 3 from Sunil"
                }
            };

            var appointmentDetails = appointmentDetailsList.FirstOrDefault(x => x.AppointmentId == appointmentId);
            return Task.FromResult(appointmentDetails ?? new AppointmentDetailsDto());
        }
    }
}
