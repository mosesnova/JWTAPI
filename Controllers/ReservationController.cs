using JWTAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    //[Authorize(Roles = "Manager")]
    public class ReservationController : ControllerBase
    {
        //[HttpGet]
        //public IEnumerable<Reservation> Get()
        //{
        //    var claims = HttpContext.User.Claims;
        //    return CreateDummyReservations().Where(t => t.Name == claims.FirstOrDefault(c => c.Type == "Name").Value);
        //}

        [HttpGet]
        public IEnumerable<Reservation> Get() => CreateDummyReservations();

        public List<Reservation> CreateDummyReservations()
        {
            List<Reservation> rList = new List<Reservation> {
            new Reservation { Id=1, Name = "Ankit", StartLocation = "New York", EndLocation="Beijing" },
            new Reservation { Id=2, Name = "Bobby", StartLocation = "New Jersey", EndLocation="Boston" },
            new Reservation { Id=3, Name = "Jacky", StartLocation = "London", EndLocation="Paris" }
            };
            return rList;
        }
    }
}
