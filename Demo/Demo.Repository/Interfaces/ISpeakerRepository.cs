using Demo.DTO.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.Repository.Interfaces
{
    public interface ISpeakerRepository
    {
        Task<List<SpeakerDTO>> GetSpeakers();

        Task<SpeakerDTO> GetSpeaker(int speakerId);

        Task Save();
    }
}