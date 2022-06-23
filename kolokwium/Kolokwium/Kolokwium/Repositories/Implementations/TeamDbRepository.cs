using Kolokwium.DTO.Responses;
using Kolokwium.Models;
using Kolokwium.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Repositories.Implementations
{
    public class TeamDbRepository : ITeamDbRepository
    {
        private readonly FirefighterContext _context;
        public TeamDbRepository(FirefighterContext context)
        {
            _context = context;
        }

        public async Task<bool> AddMemberToTeamAsync(int id,int teamId)
        {
            var inTeam = await _context.FireTruckAction.Include(x => x.IdActionNavigation).Where(x => x.IdFireTruck == id).SingleOrDefaultAsync(x => x.IdActionNavigation.EndTime == null);
            if (inAction != null)
                return false;
            var require = await _context.Action.Where(x => x.IdAction == actionId).SingleOrDefaultAsync(x => x.NeedSpecialEquipment != null);
            if (require != null)
                return false;
            var newFiretruckAction = await _context.AddAsync(new FireTruckAction
            {
                IdFireTruck = id,
                IdAction = actionId,
                AssignmentDate = DateTime.Now
            });
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<ICollection<ActionResponseDTO>> GetActionsForFirefighterAsync(int Id)
        {
            var firefighter = await _context.Firefighter.SingleOrDefaultAsync(x => x.IdFirefighter == Id);
            if (firefighter == null)
                return null;

            var res = await _context.Action.Include(x => x.FirefighterActions).ThenInclude(x => x.IdFirefighterNavigation)
                .Select(x => new TeamResponseDTO
                {
                    IdTeam = x.IdTeam,
                    StartTime = x.StartTime,
                    EndTime = x.EndTime

                }).ToListAsync();
            return res;
        }
    }
}
