using AutoMapper;
using DTO.DTOs.MailDTOs;
using DTO.DTOs.NotificationDTOs;
using DTO.DTOs.Profile;
using DTO.DTOs.RegisterDTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<NotificationAddDto, Notifications>();
            CreateMap<Notifications, NotificationAddDto>();

            CreateMap<NotificationListDto, Notifications>();
            CreateMap<Notifications, NotificationListDto>();

            CreateMap<NotificationUpdateDto, Notifications>();
            CreateMap<Notifications, NotificationUpdateDto>();

            CreateMap<LoginDto, AppUser>();
            CreateMap<AppUser, LoginDto>();

            CreateMap<LoginRegisterDto, AppUser>();
            CreateMap<AppUser, LoginRegisterDto>();

            CreateMap<LoginSignInDto, AppUser>();
            CreateMap<AppUser, LoginSignInDto>();

            CreateMap<ProfileUpdateDto, AppUser>();
            CreateMap<AppUser, ProfileUpdateDto>();

   
        }
    }
}
