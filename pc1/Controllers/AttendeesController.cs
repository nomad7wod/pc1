using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace pc1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendeesController : ControllerBase
    {
        private readonly IAttendeesRepository _attendesRepository;

        public AttendeesController(IAttendeesController attendeesRepository)


    }
}
