using Demo.DTO.Models;
using Demo.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeakersController : ControllerBase
    {
        private readonly ISpeakerRepository speakerRepository;

        public SpeakersController(ISpeakerRepository _speakerRepository)
        {
            speakerRepository = _speakerRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetSpeakers()
        {
            List<SpeakerDTO> speakersFromRepository = await speakerRepository.GetSpeakers();
            return Ok(speakersFromRepository);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpeaker(int id)
        {
            SpeakerDTO speakerFromRepository = await speakerRepository.GetSpeaker(id);
            bool validateIfSpeakerIsNotNull = speakerFromRepository == null;
            if (validateIfSpeakerIsNotNull)
            {
                return NotFound();
            }
            return Ok(speakerFromRepository);
        }
    }
}