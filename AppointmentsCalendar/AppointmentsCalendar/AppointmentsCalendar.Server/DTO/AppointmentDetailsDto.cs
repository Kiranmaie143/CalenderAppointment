using System.ComponentModel;

namespace Server.DTO
{
    public class AppointmentDetailsDto
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public string Organizer { get; set; }
        public string Description { get; set; }
        public List<string>? Attendies { get; set; }
    }
}
