using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace VTP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantsController : ControllerBase
    {
        private IParticipantService _participantService;
        public ParticipantsController(IParticipantService participantService)
        {
            _participantService = participantService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = this._participantService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("getbydepartmentid")]
        public IActionResult GetByDepartmentId(int id)
        {
            var result = this._participantService.GetAll(m => m.DepartmentId == id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("searchbyfullname")]
        public IActionResult SearchByFullName(string fullName)
        {
            var result = this._participantService.GetAll(m => (m.FirstName + m.LastName).ToLower().Contains(fullName.ToLower()));
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
