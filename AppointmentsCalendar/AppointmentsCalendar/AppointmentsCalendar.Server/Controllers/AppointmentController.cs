using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Business;
using Server.DTO;

namespace Server.Controllers
{
    [Route("api/appointments")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly ILogger<AppointmentController> _logger;
        private readonly IAppointmentBusiness _appointmentBusiness;

        public AppointmentController(ILogger<AppointmentController> logger,
                                  IAppointmentBusiness appointmentBusiness)
        {
            _logger = logger;
            _appointmentBusiness = appointmentBusiness;
        }
        //Fetchlist of appointments by month id

        [HttpGet()]
        public async Task<IEnumerable<AppointmentDto>> GetAll([FromQuery] int monthId)
        {
            return await _appointmentBusiness.GetAll(monthId);
        }
    }
}
