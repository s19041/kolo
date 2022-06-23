using Kolokwium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium.DTO.Responses;

namespace Kolokwium.Repositories.Interfaces
{
    public interface ITeamDbRepository
    {
        Task<ICollection<TeamResponseDTO>> GetTeamAsync(int Id);
        Task<bool> AddMemberToTeamAsync(int id, int teamId);
    }
}
