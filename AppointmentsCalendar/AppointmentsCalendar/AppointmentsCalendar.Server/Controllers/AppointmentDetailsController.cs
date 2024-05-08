using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Business;
using Server.DTO;

namespace Server.Controllers
{
    [Route("api/appointments/{appointmentId}/details")]
    [ApiController]
    public class AppointmentDetailsController : ControllerBase
    {
        private readonly ILogger<AppointmentDetailsController> _logger;
        private readonly IAppointmentDetailsBusiness _appointmentDetailsBusiness;

        public AppointmentDetailsController(ILogger<AppointmentDetailsController> logger,
                                  IAppointmentDetailsBusiness appointmentDetailsBusiness)
        {
            _logger = logger;
            _appointmentDetailsBusiness = appointmentDetailsBusiness;
        }
        //Fetch appointmentDetails by appointmentid
        [HttpGet]
        public async Task<AppointmentDetailsDto> GetByAppointmentId(int appointmentId)
        {
            return await _appointmentDetailsBusiness.GetById(appointmentId);
        }
    }
}
