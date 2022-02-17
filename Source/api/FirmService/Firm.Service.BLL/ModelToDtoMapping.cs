using AutoMapper;
using Firm.Models.DTO;
using Firm.Service.Repository.Models;

namespace Firm.Service.BLL
{
    /// <summary>
    /// This class is used to map db model to dto class
    /// </summary>
    public class ModelToDtoMapping : Profile
    {
        public ModelToDtoMapping()
        {
            //map accounts db model to dto class
            CreateMap<Accounts, AccountsDto>();
            CreateMap<HolidayMaster, HolidayMasterDTO>();
        }

    }
}
