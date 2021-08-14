using Demo.Database.Context;
using Demo.Database.DbModels;
using Demo.DTO.Models;
using Demo.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Repository.Repository
{
    public class SpeakerRepository : ISpeakerRepository
    {
        private readonly DemoContext _context;

        public SpeakerRepository(DemoContext context)
        {
            _context = context;
        }

        public async Task<SpeakerDTO> GetSpeaker(int speakerId)
        {
            Speaker speakerFromDatabase = await _context.Speaker
                .FirstOrDefaultAsync(speaker => speaker.SpeakerId == speakerId);
            bool validateIfSpeakerIsNotNull = speakerFromDatabase == null;
            if (validateIfSpeakerIsNotNull)
            {
                return null;
            }

            return new SpeakerDTO()
            {
                SpeakerId = speakerFromDatabase.SpeakerId,
                SpeakerName = speakerFromDatabase.SpeakerName
            };
        }

        public async Task<List<SpeakerDTO>> GetSpeakers()
        {
            List<Speaker> speakersFromDatabase = await _context.Speaker.ToListAsync();

            List<SpeakerDTO> speakersDTO = speakersFromDatabase.Select(speaker => new SpeakerDTO()
            {
                SpeakerId = speaker.SpeakerId,
                SpeakerName = speaker.SpeakerName
            }).ToList();
            return speakersDTO;
        }

        public async Task Save()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch
            {
            }
        }
    }
}