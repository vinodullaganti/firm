using Firm.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Service.BLL.Contracts
{
    public interface IUserProcessor
    {
        Task<UserDTO> GetUserDetails(UserDTO user);
    }
}
