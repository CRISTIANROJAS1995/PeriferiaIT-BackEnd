using AutoMapper;
using Core.DataTransferObject.PeriferiaIT;
using Core.Entities.User;
using PeriferiaIT.Api.Models;
using PeriferiaIT.Api.Models.User;

namespace PeriferiaIT.Api
{
    /// <summary>
    /// AutoMapperConfig
    /// </summary>
    public class AutoMapperConfig
    {
        /// <summary>
        /// Initializer
        /// </summary>
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                //User
                cfg.CreateMap<UserRegisterModel, User>();
                cfg.CreateMap<User, UserRegisterModel>();
            });
        }
    }
}