using AutoMapper;
using Firm.Models.DTO;
using Firm.Service.BLL.Contracts;
using Firm.Service.Repository.Contracts;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Firm.Service.BLL
{
    public class UserProcesser : IUserProcessor
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public UserProcesser(IUserRepository userRepository, IMapper mapper = null, ILogger logger = null)
        {
            _userRepository = userRepository;
            _logger = logger;
            _mapper = mapper;

        }

        /// <summary>
        /// GetUserDetails
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<UserDTO> GetUserDetails(UserDTO user)
        {
            try
            {
                _logger.Debug("UserProcesser: GetUserDetails-Entry");
                var userDetails = await _userRepository.GetUserDetails(user.EmailId);
                _logger.Debug("UserProcesser: GetUserDetails-Exit");
                return _mapper.Map<UserDTO>(userDetails);
            }
            catch (Exception ex)
            {
                _logger.Debug(ex, "UserProcesser: GetUserDetails-Error");
                throw;
            }
        }
    }
}
