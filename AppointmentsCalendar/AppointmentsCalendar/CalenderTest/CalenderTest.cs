using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Server.Business;
using Server.Controllers;
using Server.DTO;
using System.Web.Http;
using System.Web.Http.Results;

namespace CalenderTest
{
    public class AppointmentTest
    {
        private readonly AppointmentController _appointmentsController;
        private readonly Mock<IAppointmentBusiness> _appointmentbusinessMock = new Mock<IAppointmentBusiness>();
        private readonly Mock<ILogger<AppointmentController>> _appointmentbusinessloggerMock = new Mock<ILogger<AppointmentController>>();
        public AppointmentTest()
        {
            _appointmentsController = new AppointmentController(_appointmentbusinessloggerMock.Object, _appointmentbusinessMock.Object);
        }

        [Fact]
        public async Task Test_GetAllAppointments()
        {

            //Arrange
            List<AppointmentDto> db = new List<AppointmentDto>();
            db.Add(new AppointmentDto { Id = 1, Title = "Test Client 1" });
            db.Add(new AppointmentDto { Id = 2, Title = "Test Client 2" });
            _appointmentbusinessMock.Setup(m => m.GetAll(1)).ReturnsAsync(db);
            //_appointmentbusinessloggerMock.Setup(m => m.LogTrace(It.IsAny<string>()));
            //Act
            AppointmentController eventsController = new(null, _appointmentbusinessMock.Object);
            var employees = (await eventsController.GetAll(1));
            //Assert
            Assert.NotNull(employees);


        }

    }
    public class AppointmentDetailsTest
    {
        private readonly AppointmentDetailsController _appointmentDetailsController;
        private readonly Mock<IAppointmentDetailsBusiness> _appointmentDetailsbusinessMock = new Mock<IAppointmentDetailsBusiness>();
        private readonly Mock<ILogger<AppointmentDetailsController>> _appointmentDetailsbusinessloggerMock = new Mock<ILogger<AppointmentDetailsController>>();
        public AppointmentDetailsTest()
        {
            _appointmentDetailsController = new AppointmentDetailsController(_appointmentDetailsbusinessloggerMock.Object, _appointmentDetailsbusinessMock.Object);
        }

        [Fact]
        public async Task Test_GetAppointDetailsByid()
        {

            //Arrange
            // var applicationDetail = new AppointmentDetailsDto {Id=2,AppointmentId = 1 };
            _appointmentDetailsbusinessMock.Setup(m => m.GetById(1)).ReturnsAsync(new AppointmentDetailsDto { AppointmentId = 1 });
            // _appointmentDetailsbusinessloggerMock.Setup(m => m.LogTrace(It.IsAny<string>()));
            AppointmentDetailsController appointmentDetailsController = new(null, _appointmentDetailsbusinessMock.Object);
            //Act
            var appointmentDetails = (await appointmentDetailsController.GetByAppointmentId(1));
            //Assert
            Assert.NotNull(appointmentDetails);
            Assert.Equal(1, appointmentDetails.AppointmentId);

        }
    }






}